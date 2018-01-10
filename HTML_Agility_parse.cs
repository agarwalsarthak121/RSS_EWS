//Load an entire HTML page in a HTML doc for parsing
HtmlWeb web = new HtmlWeb();  
HtmlDocument document = web.Load("http://www.c-sharpcorner.com");  

//Get a list of all the hyperlinks
HtmlNode[] nodes = document.DocumentNode.SelectNodes("//a").ToArray();  
foreach (HtmlNode item in nodes)  
{  
    Console.WriteLine(item.InnerHtml);  
}  

//Get a specified div tag
HtmlNode node = document.DocumentNode.SelectNodes("//div[@id='div1']").First();  

//To select all hyperlinks in an array
HtmlNode [] aNodes2 = document2.DocumentNode.SelectNodes("//div[@id='div1']//a").ToArray();

//Further filtering the hyperlinks
HtmlNode[] nodes = document2.DocumentNode.SelectNodes("//a").Where(x=>x.InnerHtml.Contains("div2")).ToArray();  

