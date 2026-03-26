
//using (StreamWriter sw = File.CreateText("Deneme.txt"))
//{
//sw.WriteLine("merhabaaa");
//sw.WriteLine("Hapşuu");
//sw.WriteLine("kapalıyızz");

//}
//using (StreamWriter sw = File.AppendText("Deneme.txt"))
//{
//sw.WriteLine("selan");
//sw.WriteLine("Hapşcccuku");
//sw.WriteLine("kapalıyızz");

//}

//File.WriteAllText("Deneme.txt", "merhaba");

//using StreamReader sr = File.OpenText("Deneme.txt");

//var s = "";
//while ((s = sr.ReadLine()) != null)
//{

//    Console.WriteLine(s);
//}

//strings onuc = File.ReadAllText("Deneme.txt");
//string[] sonuc = File.ReadAllLines("Deneme.txt");
//Console.WriteLine(sonuc[0]);
//Console.WriteLine(sonuc[2]);
//Console.WriteLine(sonuc[4]);
//Console.WriteLine(sonuc[5]);


//sw.Close();


// -----File-----------

//Directory.CreateDirectory("temp");
//Directory.CreateDirectory("temp/deneme");

//if(Directory.Exists("temp/deneme"))
//    Directory.Delete("temp/deneme");
//else
//    Console.WriteLine("Silmek istediğiniz klasör yok, bulunmamaktadır");



//Console.WriteLine(path);
//Directory.CreateDirectory(path);

string rootpath = Directory.GetCurrentDirectory();

string[] dirs = Directory.GetDirectories(rootpath, "*", SearchOption.TopDirectoryOnly);

