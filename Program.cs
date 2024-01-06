using System.Reflection;

// erisim_belirteci geri donus_tipi method_adı(parametreListesi-arguman)
// {
//     komutlar
//     return;
// }


int a = 2;
int b = 3;

Console.WriteLine(a + b);

int sonuc = Topla(a, b);
Console.WriteLine(sonuc);

Methods sample = new Methods();
sample.WriteOnScreen(sonuc.ToString());

// int sonuc2 = sample.increaseAndSum(a,b);
int sonuc2 = sample.increaseAndSum(ref a, ref b);
sample.WriteOnScreen(sonuc2.ToString());
sample.WriteOnScreen(Convert.ToString(a + b));
int Topla(int value1, int value2)
{
    return (value1 + value2);
}

class Methods
{

    public void WriteOnScreen(string dat)
    {
        Console.WriteLine(dat);
    }

    public int increaseAndSum(ref int value3, ref int value4)
    {
        value3 += 1;
        value4 += 1;
        return value3 + value4;
    }
}