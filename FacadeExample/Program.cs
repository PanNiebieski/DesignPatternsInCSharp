using System.Net;

//string url = "http://www.cezarywalenciuk.pl/robots.txt";
//var request = WebRequest.Create(url);
//request.Credentials = CredentialCache.DefaultCredentials;

//var response = request.GetResponse();
//var dataStream = response.GetResponseStream();
//var reader = new StreamReader(dataStream);
//string responseFromServer = reader.ReadToEnd();

//Console.WriteLine(responseFromServer);
//reader.Close();
//response.Close();


string url1 = "http://www.cezarywalenciuk.pl/robots.txt";
var responseFromServer1 = new WebClient().DownloadString(url1);
Console.WriteLine(responseFromServer1);