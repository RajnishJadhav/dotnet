using DD;
using jj;


Account acc = new Account();
acc.Balance=10000;



acc.Deposit(1000);
acc.Withdraw(5000);
//NotificationServices ob=new NotificationServices();

 Notification not=new Notification(NotificationServices.Sendsms);
// Notification not1=new Notification(NotificationServices.Sendemail);
// Notification not2=new Notification(NotificationServices.Sendwp);
 //not("askfjskfj");
acc.Nevent+=NotificationServices.Sendsms;