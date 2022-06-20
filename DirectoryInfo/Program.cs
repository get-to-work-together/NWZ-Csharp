namespace EnumerateDirectoriesEx
{
    class Program
    {
        static void Main(string[] args)
        {
            var myDir = "C:\\";
            var dirInfo = new DirectoryInfo(myDir);

            var dirs = dirInfo.EnumerateDirectories("*", new EnumerationOptions
            { RecurseSubdirectories = false });

            foreach (var name in dirs)
            {
                Console.WriteLine(name);
            }
        }
    }
}