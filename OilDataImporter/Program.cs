using CsvHelper;
using OilDataImporter.Models;
using System.Globalization;
using System.Net;
using System.Text;
using WinSCP;

Console.WriteLine("Hello, World!");
 List<Wearcheck> wcRecord= new ();
 List<OilWatch> owRecord= new ();


try
{
    // Setup session options
    SessionOptions sessionOptions = new SessionOptions
    {
        Protocol = Protocol.Ftp,
        HostName = "ftp.wearcheck.co.za",
        UserName = "afrimat",
        Password = "a6f7eQX4wCWJ",        
    };

    using (Session session = new Session())
    {
        // Connect
        session.Open(sessionOptions);

        
        const string localPath = @"C:\Repos\OilDataImporter\Wearcheck";

        // Get list of files in the directory
        RemoteDirectoryInfo directoryInfo = session.ListDirectory(session.HomePath);

        // Select the most recent file
        RemoteFileInfo latest =
            directoryInfo.Files
                .Where(file => !file.IsDirectory)
                .OrderByDescending(file => file.LastWriteTime)
                .FirstOrDefault();

        // Any file at all?
        if (latest == null)
        {
            throw new Exception("No file found");
        }
        try
        {
        session.DuplicateFile(latest.FullName, localPath);

        }catch(Exception ex)
        {

        }
        // Download the selected file
    }

    return 0;
}
catch (Exception e)
{
    Console.WriteLine("Error: {0}", e);
    return 1;
}






/*


using (var reader = new StreamReader("C:\\Repos\\OilDataImporter\\Wearcheck\\FFD80AFABA29C0489C6B1EEF16A558B93A.csv"))
using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
{
    Console.WriteLine("------------");
    csv.Context.RegisterClassMap<WearcheckClassMap>();
     wcRecord = csv.GetRecords<Wearcheck>().ToList();
}
Console.WriteLine("------------");
foreach (var i in wcRecord)
{
    Console.WriteLine(i.SAMPLE_NUMBER);
}

*/




//ow
string owUrl = "https://oilwatch.biz/export/afrimat/afrimat_csv_condensed.php?pass=Afr1m@t1Z7785j&date=all";
var httpClient = new HttpClient();

var httpResult = await httpClient.GetAsync(owUrl);
using var resultStream = await httpResult.Content.ReadAsStreamAsync();
using (var reader = new StreamReader(resultStream))
using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
{
    Console.WriteLine("------------");
    csv.Context.RegisterClassMap<OilWatchClassMap>();
    owRecord = csv.GetRecords<OilWatch>().ToList();
}
Console.WriteLine("------------");
foreach (var i in owRecord)
{
    Console.WriteLine(i.SAMPLE_NUMBER);
}