namespace deeplay_test
{
    internal class Collections
    {
        #region JobTitle Collections

        public static Dictionary<int, string> JobTitlesDict = new Dictionary<int, string>
        {
            { 0, "Директор"},
            { 1, "Руководитель подразделения" },
            { 2, "Контролер"},
            { 3, "Рабочий" }
        };

        public static Dictionary<string, int> JobTitlesReverseDict = new Dictionary<string, int>
        {
            {"Директор" , 0},
            {"Руководитель подразделения", 1},
            {"Контролер", 2},
            {"Рабочий", 3}
        };

        public static string[] JobTitles = new string[]
        {
            "Директор",
            "Руководитель подразделения",
            "Контролер",
            "Рабочий"
        };

        public static string[] JobTitleFilters = new string[]
        {
            "Любая",
            "Директор",
            "Руководитель подразделения",
            "Контролер",
            "Рабочий"
        };

        #endregion

        #region Unique Infromation Collections

        public static Dictionary<int, string> DirectorUniqueInfoDict = new Dictionary<int, string>
        {
            { 0, "Генеральный"},
            { 1, "Технический" },
            { 2, "Финансовый"},
            { 3, "Коммерческий" }
        };

        public static Dictionary<string, int> DirectorUniqueInfoReverseDict = new Dictionary<string, int>
        {
            {"Генеральный" , 0},
            {"Технический", 1},
            {"Финансовый", 2},
            {"Коммерческий", 3}
        };

        public static Dictionary<int, string> DepartmentHeadUniqueInfoDict = new Dictionary<int, string>
        {
            { 0, "Подразделение 1"},
            { 1, "Подразделение 2"},
            { 2, "Подразделение 3"}
        };

        public static Dictionary<string, int> DepartmentHeadUniqueInfoReverseDict = new Dictionary<string, int>
        {
            {"Подразделение 1" , 0},
            {"Подразделение 2", 1},
            {"Подразделение 3", 2}
        };

        #endregion

        public static Dictionary<int, string> SexDict = new Dictionary<int, string>
        {
            { 0, "Женский"},
            { 1, "Мужской" },
        };

        public static Dictionary<string, int> SexReverseDict = new Dictionary<string, int>
        {
            {"Женский" , 0},
            {"Мужской", 1}
        };

        public static string[] DepartmentFilters = new string[]
        {
            "Любое",
            "Подразделение 1",
            "Подразделение 2",
            "Подразделение 3"
        };

        public static string[] Departments = new string[]
        {
            "Подразделение 1",
            "Подразделение 2",
            "Подразделение 3"
        };

        public static Dictionary<int, string> JobTitleFiltersDict = new Dictionary<int, string>
        {
            { 0, "Любая"},
            { 1, "Директор"},
            { 2, "Руководитель подразделения" },
            { 3, "Контролер"},
            { 4, "Рабочий" }
        };

        public static string[] Sexes = new string[]
        {
            "Женский",
            "Мужской"
        };

        public static string[] DirectorUniqueInfo =
        {
            "Генеральный",
            "Технический",
            "Финансовый",
            "Коммерческий"
        };

        /*
            Должность - информация:
            Директор - полное название, вроде Генералльный Директор (предположительно)
            Руководитель подразделения - название подразделения
            Контролер - неизвестно
            Рабочий - ФИО руководителя
        */
    }
}
