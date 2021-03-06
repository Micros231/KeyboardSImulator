﻿namespace KeybordSimulator.Shared.Services
{
    /// <summary>
    /// Статический класс, где хранятся константы необходимые для службы симулятора
    /// </summary>
    public static class SimulatorServiceConsts
    {
        /// <summary>
        /// Сколько обновлений производит поток службы в секнуду
        /// (больше - быстрее происходят обновления, но увеличивается нагрузка на компьютер)
        /// </summary>
        public const int ThreadUpdatePerSecond = 30;
        /// <summary>
        /// Максимальное количество символов, которое можно написать в облась ввода, 
        /// если больше, то строка начнет двигаться (50 - нормальное значение, больше 100 лучше не делать, так визуал сломается)
        /// </summary>
        public const int MaxCharsInLine = 50;
        /// <summary>
        /// Константа, означающая сколько времени необходимо на написание одного символа, оно работает для всех уровней и
        /// необходимо при генерации таймера
        /// </summary>
        public const float OneTimeInOneChar = 0.3f;
    }
}
