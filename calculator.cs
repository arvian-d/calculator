class calculator 
{
	static void Main {string [] args}{
	int a = 10;
	int b = 0;
	
	Console.WriteLine("Hasil Penambahan : {0} + {1} = {2}", a, b, penambahan(a, b));
	Console.WriteLine("Hasil Pengurangan : {0} - {1} = {2}", a, b, pengurangan(a, b));
	
	Console.WriteLine("\n Tekan Sembarang key untuk keluar");
	Console.ReadKey();
	
	}
	static int penambahan(int a, int b)
	{
	return a + b;
	}
	static int pengurangan(int a, int b)
	{
	return a - b;
	}
	
}
