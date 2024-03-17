using System;
using HtmlAgilityPack;

/*class Program
{
       static void Main(string[] args)
       {
           // Запрос ссылки у пользователя
           Console.WriteLine("Введите ссылку на страницу:");
           string url = Console.ReadLine();

           // Создаем объект WebClient для загрузки HTML-кода страницы
           HtmlWeb web = new HtmlWeb();

           // Добавляем пользовательский агент и пустые куки
           web.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.3";
           web.PreRequest += request =>
           {
               request.CookieContainer = new System.Net.CookieContainer();
               return true;
           };

           HtmlDocument htmlDoc = web.Load(url);

           // Выводим загруженный HTML-код
           Console.WriteLine("Загруженный HTML-код страницы:");
           Console.WriteLine(htmlDoc.Text);

           // Используем XPath, чтобы найти элемент с заголовком
           HtmlNode titleNode = htmlDoc.DocumentNode.SelectSingleNode("//p[@class='bigtext']");

           // Проверяем, найден ли узел с заголовком
           if (titleNode != null)
           {
               // Получаем текст из найденного узла
               string title = titleNode.InnerText;

               // Выводим заголовок
               Console.WriteLine("\nНазвание публикации: " + title);
           }
           else
           {
               Console.WriteLine("\nЗаголовок не найден.");
           }

           // Используем XPath, чтобы найти информацию о томе, номере, годе и страницах
           HtmlNode volumeNode = htmlDoc.DocumentNode.SelectSingleNode("//td[@width='574']/font[1]");
           HtmlNode numberNode = htmlDoc.DocumentNode.SelectSingleNode("//td[@width='574']/a");
           HtmlNode yearNode = htmlDoc.DocumentNode.SelectSingleNode("//td[@width='574']/font[2]");
           HtmlNode pagesNode = htmlDoc.DocumentNode.SelectSingleNode("//td[@width='574']/div/font");

   // Проверяем, найдены ли узлы
           if (volumeNode != null && numberNode != null && yearNode != null && pagesNode != null)
           {
               // Получаем текст из найденных узлов
               string volume = volumeNode.InnerText;
               string number = numberNode.InnerText;
               string year = yearNode.InnerText;
               string pages = pagesNode.InnerText;

               // Выводим информацию о томе, номере, годе и страницах
               Console.WriteLine("\nТом: " + volume);
               Console.WriteLine("Номер: " + number);
               Console.WriteLine("Год: " + year);
               Console.WriteLine("Страницы: " + pages);
           }
           else
           {
               Console.WriteLine("\nИнформация о томе, номере, годе или страницах не найдена.");
           }


           // Используем XPath, чтобы найти все элементы span с классом 'help pointer'
           HtmlNodeCollection nameNodes = htmlDoc.DocumentNode.SelectNodes("//div[@style='display: inline-block; white-space: nowrap']/span[@class='help pointer']");

           // Проверяем, найдены ли узлы
           if (nameNodes != null)
           {
               // Выводим ФИО
               Console.WriteLine("\nФИО:");
               foreach (HtmlNode nameNode in nameNodes)
               {
                   string name = nameNode.InnerText.Trim();
                   Console.WriteLine(name);
               }
           }
           else
           {
               Console.WriteLine("\nФИО не найдены.");
           }

           // Используем XPath, чтобы найти название журнала
           HtmlNode journalNode = htmlDoc.DocumentNode.SelectSingleNode("//td[@width='504']/a");

           // Проверяем, найден ли узел с названием журнала
           if (journalNode != null)
           {
               // Получаем текст из найденного узла
               string journal = journalNode.InnerText;

               // Получаем ссылку из найденного узла
               string journalLink = journalNode.GetAttributeValue("href", string.Empty);

               // Формируем полный URL, добавляя базовый URL к относительной ссылке
               string baseUrl = "https://www.elibrary.ru/"; // Базовый URL
               string fullUrl = baseUrl + journalLink;

               // Выводим название журнала и ссылку
               Console.WriteLine("\nНазвание журнала: " + journal);
               Console.WriteLine("Ссылка на журнал: " + fullUrl);

               // Загружаем HTML-код страницы по найденной ссылке
               HtmlDocument newHtmlDoc = web.Load(fullUrl);

               // Используем XPath, чтобы найти новую ссылку
               HtmlNode newLinkNode = newHtmlDoc.DocumentNode.SelectSingleNode("//div[@style='width:540px; margin:10px 20px 10px 20px; border:0; padding:0; text-align: center; font-size: 10pt;']/a");

               // Проверяем, найден ли узел с новой ссылкой
               if (newLinkNode != null)
               {
                   // Получаем новую ссылку из найденного узла
                   string newLink = newLinkNode.GetAttributeValue("href", string.Empty);

                   // Формируем полный URL для новой ссылки
                   string newFullUrl = baseUrl + newLink;

                   // Выводим новую ссылку
                   Console.WriteLine("Новая ссылка: " + newFullUrl);
               }
               else
               {
                   Console.WriteLine("\nНовая ссылка не найдена.");
               }
           }
           else
           {
               Console.WriteLine("\nНазвание журнала не найдено.");
           }
    }
}*/
