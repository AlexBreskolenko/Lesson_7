//Работа с директориями : 
Console.Clear();

//Метод принимает патч и отступы по умолчанию
void CatalogInfo(string path, string indet = " ")
{
    //Получаем инфу о директории 
    DirectoryInfo catalog = new DirectoryInfo(path);
    //Получаем массив всех папок в этой папке
    DirectoryInfo[] catalogs = catalog.GetDirectories();
    //Пробегаем по ним
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indet}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indet + " ");
    }
    //Получим весь список файлов в этой директории
    FileInfo[] files = catalog.GetFiles();
    //Покажем их
    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indet}{files[i].Name}");
    }
}

string path = "C:/Users/abres/Desktop/Study_GB/Homework_3_C#";

CatalogInfo(path);
/*
//Создаем тип на директорию
DirectoryInfo di = new DirectoryInfo(path);
//Вывод когда была созданна папка
Console.WriteLine(di.CreationTime);

//тип который содержит инфу о файле
FileInfo[] fi = di.GetFiles();

//Вывод содержимого файла
for (int i = 0; i < fi.Length; i++)
{
    Console.WriteLine(fi[i].Name);
}
*/