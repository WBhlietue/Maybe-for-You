public class ChekingAccount extends BankAccount {
   
    private int fee;

    public ChekingAccount(int f, String acc, int balance) {
        fee = f;
        accountNumber = acc;
        totalBalance  = balance;
    }

    public void DeductFee() {
        WithDraw(fee);
    }
}
