namespace TemplateWorker_Hisham
{
    class AppSettings
    {

        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public int Port { get; set; }
        public string UserID { get; set; }
        public string Password { get; set; }
        public string SenderEmail { get; set; }
        public string ReceiverEmail { get; set; }
        public string TemplateFileName { get; set; }
        public Columnsmap ColumnsMap { get; set; }
        public long[] IDsToSkip { get; set; }

        public class Columnsmap
        {
            public string Prenom { get; set; }
            public string Nom { get; set; }
            public string MSIDN { get; set; }
            public string NationalIDN { get; set; }
            public string Date_Naissance { get; set; }
            public string adresse { get; set; }
            public string Ville { get; set; }
            public string Place_of_Birth { get; set; }
            public string email { get; set; }
        }


    }


}
