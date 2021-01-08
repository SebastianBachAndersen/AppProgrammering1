namespace Megasejapp
{
    public class Project
    {
        public string CompanyName { get; set; }
        public string JobTitle { get; set; }
        public string Description { get; set; }

        public string StartDate { get; set; }
        public string EndDate { get; set; }



        public override string ToString()
        {
            return CompanyName;
        }

    }
}