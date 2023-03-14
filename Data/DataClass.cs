namespace Калькулятор.Data
{
    internal class DataClass
    {
        public string Plus { get; set; } = "+";
        public string Minus { get; set; } = "-";
        public string Division { get; set; } = "/";
        public string Multyplication { get; set; } = "*";
        public string Equally { get; set; } = "=";
        public string Point { get; set; } = ".";
        public string Procent { get; set; } = "%";
        public string Root { get; set; } = "√";

        public int GetNumber(int Numb)
        {
            return Numb;
        }
        
        /// <summary>
        /// Метод который удаляет 1 символ из строки. Так же 
        /// данный метод ловит исключение, что бы не было ошибки
        /// при полном удалении всех символов в строке
        /// </summary>
        /// <param name="Text"></param>
        /// Метод принимающий параметр в видет строки
        /// <returns></returns>
        public string _DeleteSumbol(string Text)
        {
            int _IndexSumbol = Text.Length -1;
            try
            {
                Text = Text.Remove(_IndexSumbol);
            }
            catch (System.Exception) { }

            return Text;
        }
    }
}
