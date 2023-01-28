public class Borluulalt {
    int zaragdsanToo;
    int niitOrlogo;
    int niitHungulult;
    int negjUne;
    int hungulultHamgiinBagaToo;
    int hungulultHuvi;

    int hymdral = 0;

    public Borluulalt(int negjU, int hungulultBagaToo, int hungulultH)
    {
        zaragdsanToo = 0;
        negjUne = negjU;
        hungulultHamgiinBagaToo = hungulultBagaToo;
        hungulultHuvi = hungulultH;
    }

    public void registerSale(int n){
        int price = CalcHungulult(n);
        AddNiit(price);
        zaragdsanToo+=n;
    }

    int CalcHungulult(int n){
        if(n >= hungulultHamgiinBagaToo){
            int price =  negjUne * n * (100 - hungulultHuvi) / 100;
            hymdral += (negjUne*n - price);
            return price;
        }
        return negjUne * n;
    }

    void AddNiit(int price){
        niitOrlogo += price;
    }

    public void DisplaySell(){
        System.out.println("zaragdsan too: " + zaragdsanToo + ", niitOrlogo: " + niitOrlogo + ", hungulult: " + hymdral);
    }
}
