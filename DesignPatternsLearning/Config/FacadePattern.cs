using DesignPatternsLearning.Structural.Facade;

namespace DesignPatternsLearning.Config
{
    public class FacadePattern : IPattern
    {
        public void Test()
        {
            BankService myBankService = new BankService();

            int mySaving = myBankService.CreateNewAccount("saving", 500.00m);
            int myInvestment = myBankService.CreateNewAccount("investment", 1000.00m);

            myBankService.TransferMoney(myInvestment, mySaving, 300.00m);
        }
    }
}
