using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using KeybordSimulator.Models;
using KeybordSimulator.Services;
using KeybordSimulator.Shared.Services;

namespace KeybordSimulator.Forms
{
    /// <summary>
    /// Форма симулятора
    /// </summary>
    public partial class SimulatorForm : Form
    {
        /// <summary>
        /// Поле для чтения в отором содержится служба симулятора
        /// </summary>
        private readonly SimulatorService _simulatorService;
        /// <summary>
        /// Делегат экшена, который вызывается при обновлении потока службы симулятора
        /// </summary>
        private Action OnUpdateInvokeAction;
        /// <summary>
        /// Булевое поле, которое проверяет была ли нажата клавиша или нет
        /// </summary>
        private bool _isKeyPressed;
        /// <summary>
        /// Конструктор создания типа, который производит вервоначальную инициализацию
        /// </summary>
        /// <param name="simulatorModel">Модель симулятора</param>
        public SimulatorForm(SimulatorModel simulatorModel)
        {
            InitializeComponent();
            _simulatorService = new SimulatorService(simulatorModel);
            _simulatorService.GenerateSimulatorMap();
            InitUI();
        }

        /// <summary>
        /// Обработчик события загрузки загрузки формы, 
        /// в котором регестрируются обработчики событий,
        /// запускается таймер и служба симулятора
        /// </summary>
        private void SimulatorForm_Load(object sender, EventArgs e)
        {
            KeyPress += SimulatorFrom_KeyPress;
            KeyUp += SimulatorForm_KeyUp;
            _simulatorService.OnUpdateSimulator += _simulatorService_OnUpdateSimulator;
            _simulatorService.OnWin += _simulatorService_OnWin;
            _simulatorService.OnLose += _simulatorService_OnLose;
            OnUpdateInvokeAction += OnUpdateUI;
            _simulatorService.Start();
            TimerControl.Start();
        }
        /// <summary>
        /// Обработчик события, когда мы отпускам клавишу, нужно, чтобы регестрировать одно нажатие за раз
        /// </summary>
        private void SimulatorForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (!_simulatorService.IsPaused)
            {
                _isKeyPressed = false;
            }
        }
        /// <summary>
        /// Обработчик события, когда мы нажимаем на клавишу, тут магичиские условия))
        /// Проверяем, стоит ли на паузе служба, дальше проверяем нажатую клавишу на валидность,
        /// после смотрим, нажали ли мы backspace или букву/цифру и от этого производим некоторую работу с картой смулятора
        /// </summary>
        private void SimulatorFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!_simulatorService.IsPaused)
            {
                if (CheckIsValideKeyPressed(e.KeyChar))
                {
                    if (e.KeyChar == '\b')
                    {
                        var countChars = _simulatorService.SimulatorMapModel.PressedChars.Count;
                        if (countChars <= 0)
                        {
                            return;
                        }
                        if (_simulatorService.SimulatorMapModel.CompleteChars.Count == _simulatorService.SimulatorMapModel.PressedChars.Count)
                        {
                            return;
                        }
                        _simulatorService.SimulatorMapModel.PressedChars.RemoveAt(countChars - 1);
                    }
                    else
                    {
                        if (!_isKeyPressed)
                        {
                            _simulatorService.KeyPressCount++;
                            _simulatorService.SimulatorMapModel.PressedChars.Add(e.KeyChar);
                            if (_simulatorService.SimulatorMapModel.CurrentIndex < _simulatorService.SimulatorMapModel.NeedChars.Count)
                            {
                                var needChar = _simulatorService.SimulatorMapModel.NeedChars[_simulatorService.SimulatorMapModel.CurrentIndex];
                                if (_simulatorService.SimulatorMapModel.CurrentIndex == _simulatorService.SimulatorMapModel.ErrorIndex)
                                {
                                    _simulatorService.SimulatorMapModel.IsError = false;
                                }
                                if (e.KeyChar.ToString().Equals(needChar.ToString()) && !_simulatorService.SimulatorMapModel.IsError)
                                {
                                    var nextIndex = _simulatorService.SimulatorMapModel.CurrentIndex + 1;
                                    if (nextIndex == _simulatorService.SimulatorMapModel.NeedChars.Count)
                                    {
                                        _simulatorService.SimulatorMapModel.CompleteCountWords++;
                                        _simulatorService.Win();
                                    }
                                    else
                                    {
                                        if (_simulatorService.SimulatorMapModel.NeedChars[nextIndex] == ' ')
                                        {
                                            _simulatorService.SimulatorMapModel.CompleteCountWords++;
                                        }
                                    }

                                    _simulatorService.SimulatorMapModel.CompleteChars.Add(e.KeyChar);
                                }
                                else
                                {
                                    OnError();
                                }
                            }
                            else
                            {
                                OnError();
                            }
                        }
                    }
                }
                _isKeyPressed = true;
            }
        }
        /// <summary>
        /// Обработчик события, который вызывается, когда таймер делает тик(происходит каждую секунду)
        /// тут проверяется на то стоит ли пауза, преодолели ли мы максимум таймера и обрабатываем скорость нажатия клавиш, 
        /// а также добавляем значения в сам таймер 
        /// </summary>
        private void TimerControl_Tick(object sender, EventArgs e)
        {
            if (_simulatorService.IsPaused)
            {
                return;
            }
            else
            {
                var speed = _simulatorService.KeyPressCount * 60;
                if (_simulatorService.SimulatorMapModel.IsError)
                {
                    speed = 0;
                }
                _simulatorService.SpeedCount = (speed + _simulatorService.LastSpeed) / 2;
                _simulatorService.LastSpeed = _simulatorService.SpeedCount;
                _simulatorService.KeyPressCount = 0;
            }
            if (_simulatorService.Timer >= _simulatorService.MaxTimer)
            {
                TimerControl.Stop();
                _simulatorService.Timer = _simulatorService.MaxTimer;
                _simulatorService.Lose();
                return;
            }
            _simulatorService.Timer++;
        }
        /// <summary>
        /// Обработчик события нажатия кнопки паузы или продолжения работы, 
        /// которая ставит службу на паузу или возобновляет работу
        /// </summary>
        private void PauseOrResumeButton_Click(object sender, EventArgs e)
        {
            if (_simulatorService.IsPaused)
            {
                PauseOrResumeButton.Text = "Пауза";
                _simulatorService.Resume();
            }
            else
            {
                PauseOrResumeButton.Text = "Возобновить";
                _simulatorService.Pause();
            }
        }
        /// <summary>
        /// Обработчик события клавиши нажатия кнопки "Отмена",
        /// закрывает форму
        /// </summary>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Обработчик события, которое вызывается перед тем, как форма закроется, тут останавливается таймер, служба, а
        /// также происходит отписка от событий
        /// </summary>
        private void SimulatorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            KeyPress -= SimulatorFrom_KeyPress;
            _simulatorService.OnUpdateSimulator -= _simulatorService_OnUpdateSimulator;
            OnUpdateInvokeAction -= OnUpdateUI;
            TimerControl.Stop();
            _simulatorService.Stop();
        }
        /// <summary>
        /// Обработчик события, которое вызыввается, когда поток службы обновился, необходим для обновления UI формы
        /// </summary>
        private void _simulatorService_OnUpdateSimulator()
        {
            if (_simulatorService.CancellationToken.IsCancellationRequested)
            {
                return;
            }
            try
            {
                if (IsContolValid(this))
                {
                    Invoke(OnUpdateInvokeAction);
                }
            }
            catch (ObjectDisposedException)
            {
                _simulatorService.Stop();
            }
        }
        /// <summary>
        /// Обработчик события, которое вызывается, когда происходит выйгрыш, 
        /// тут создается SaveFileDialog, при помощи которого как раз таки и сохраняется результат.
        /// В самом конце закрывается форма
        /// </summary>
        private void _simulatorService_OnWin()
        {
            var result = MessageBox.Show("Вы успешно справились! Желаете Сохранить результат?", "Выйгрыш", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "txt files (*.txt)|*.txt";
                saveFile.FileName = $"{_simulatorService.SimulatorModel.UserName} - {_simulatorService.SimulatorModel.Level.LevelName}.txt";
                saveFile.FilterIndex = 2;
                saveFile.RestoreDirectory = true;
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    using (var saveStream = saveFile.OpenFile())
                    using (var writer = new StreamWriter(saveStream))
                    {
                        writer.Write(_simulatorService.GenerateResult());
                    }
                }
            }
            Close();
        }
        /// <summary>
        /// Обработчик события, которое вызывается, когда происходит проигрыш
        /// </summary>
        private void _simulatorService_OnLose()
        {
            var result = MessageBox.Show("Вы не справились! Попробуйте снова", "Проигрыш", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
                Close();
            }
        }
        /// <summary>
        /// Метод первоначальной инициализации UI
        /// </summary>
        private void InitUI()
        {
            LevelNameLabel.Text = _simulatorService.SimulatorModel.Level.LevelName;
            PauseOrResumeButton.Text = "Пауза";
        }
        /// <summary>
        /// Метод, который обновляет UI, вызыввается, когда обновляется поток службы
        /// </summary>
        private void OnUpdateUI()
        {
            TimeCountLabel.Text = _simulatorService.TimerSpan.ToString(@"mm\:ss");
            ErrorCountLabel.Text = _simulatorService.Errors.ToString();
            SpeedCountLabel.Text = $"{_simulatorService.SpeedCount} слов/м";
            WordCountLabel.Text =
                $"{_simulatorService.SimulatorMapModel.CompleteCountWords}/" +
                $"{_simulatorService.SimulatorMapModel.CountWords}";
            UpdateLineLabels();
        }
        /// <summary>
        /// Метод обновления значений ввода и необходимого текста, происходит, вызыввается, 
        /// когда происходит основное обновление UI
        /// </summary>
        private void UpdateLineLabels()
        {
            var EnterLineText = new string(_simulatorService.SimulatorMapModel.PressedChars.ToArray());
            var NeedLineText = new string(_simulatorService.SimulatorMapModel.NeedChars.ToArray());
            string CompleteEnterLineText = EnterLineText;
            string CompleteNeedLineText = NeedLineText;
            _simulatorService.SimulatorMapModel.CurrentIndex = EnterLineText.Length;
            int spaceChars = 0;
            if (_simulatorService.SimulatorMapModel.CurrentIndex > SimulatorServiceConsts.MaxCharsInLine)
            {
                spaceChars = _simulatorService.SimulatorMapModel.CurrentIndex - SimulatorServiceConsts.MaxCharsInLine;
                CompleteEnterLineText = CompleteEnterLineText.Substring(spaceChars, SimulatorServiceConsts.MaxCharsInLine);
                if (NeedLineLabel.Text.Length != 0)
                {
                    CompleteNeedLineText = CompleteNeedLineText.Remove(0, spaceChars);
                }
                else
                {
                    CompleteNeedLineText = string.Empty;
                }
            }
            EnterLineLabel.Text = CompleteEnterLineText;
            NeedLineLabel.Text = CompleteNeedLineText;
        }
        /// <summary>
        /// Проверка на валдиность нажатой кнопки, тут проверяется только нажали ли мы ESC или нет
        /// </summary>
        /// <param name="keyChar">Нажатый символ</param>
        /// <returns></returns>
        private bool CheckIsValideKeyPressed(char keyChar)
        {
            if (keyChar == '\u001B')
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Метод проверки, на то валдина ли форма или нет, нужно, чтобы предуберечь рограмму от ошибки,
        /// когда форма закрыта, а поток службы пытается обновить данные UI
        /// </summary>
        /// <param name="myControl">Передача Control</param>
        /// <returns></returns>
        private bool IsContolValid(Control myControl)
        {
            if (myControl == null) return false;
            if (myControl.IsDisposed) return false;
            if (myControl.Disposing) return false;
            if (!myControl.IsHandleCreated) return false;
            return true;
        }
        /// <summary>
        /// Метод, который добовляет ошибку в карту симулятора и также устанавливает индекс ошибки на последнем символе
        /// </summary>
        private void OnError()
        {
            _simulatorService.Errors++;
            if (!_simulatorService.SimulatorMapModel.IsError)
            {
                _simulatorService.SimulatorMapModel.ErrorIndex = _simulatorService.SimulatorMapModel.CurrentIndex;
            }
            _simulatorService.SimulatorMapModel.IsError = true;

        }
    }
}
