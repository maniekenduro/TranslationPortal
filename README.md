# TranslationPortal
Simply ASP.NET MVC application that takes a text string from user and turns it into "l33t sp34k" :)

- Create Sql database server and call it TranslatorPortal
- Create Table by thix query 

Create Table Log (
ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
API VARCHAR(255),
OriginalText VARCHAR(255),
NewText VARCHAR(255),
SendDate datetime,
);

- In SendDate datetime setting change [Default Value or Binding] to getdate()
- Now all logs from API will be saved in sqlserver:)
- Open solution TranslationPortal, run application and enjoy:)
