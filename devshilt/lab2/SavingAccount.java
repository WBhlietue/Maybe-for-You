public class SavingAccount extends BankAccount {
    private int intestRate;

    public SavingAccount(int rate, String acc, int balance) {
        intestRate = rate;
        accountNumber = acc;
        totalBalance = balance;
    }

    public void AddInterest() {
        Deposit(GetBalance() * intestRate / 100);
    }
}

