using Newtonsoft.Json;
namespace DSirLib
{
    public class Class1
    {
        public void Ser(string sems, DateTime dttm)
        {
            string sems1 = JsonConvert.SerializeObject(sems + " || " + dttm);
            File.WriteAllText("C:\\Users\\Dar0n\\Downloads\\игры\\rip.json", sems1);
        }
        public string Des()
        {
            string sems = File.ReadAllText("C:\\Users\\Dar0n\\Downloads\\игры\\rip.json");
            string list_hist = JsonConvert.DeserializeObject<string>(sems);
            return list_hist;
        }
    }
}