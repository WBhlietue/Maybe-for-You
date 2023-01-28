public abstract class BankAccount {
    protected String accountNumber;
    protected int totalBalance;

    protected void Deposit(int value) {
        totalBalance += value;
        System.out.println(accountNumber +" dugaartai dansand " + value + "-iin orlogo orj " + totalBalance + "-tai bolloo");
    }

    protected void WithDraw(int value) {
        if (totalBalance >= value) {
            totalBalance -= value;
            System.out.println(accountNumber +" dugaartai dansand " + value + "-iin zarlaga garj " + totalBalance + "-tai bolloo");
        } else {
            System.out.println(accountNumber +" dugaartai dansnii " + "uldegdel hureltsehgui baina");
        }
    }

    protected int GetBalance() {
        return totalBalance;
    }
}
