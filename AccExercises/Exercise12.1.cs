using System;

class Customer {
    public int CustId;
    public string CustName;

    public Customer(int custId, string custName){   //constructor
        CustId = custId;
        CustName = custName;
    }
}

class RegularCustomer : Customer {
    public string Payment;

    public RegularCustomer(int custId, string custName, string payment) : base(custId, custName){
        CustId = custId;
        CustName = custName;
        Payment = payment;
    }
}
class Inheritance {
    public static void Main(string[] args){
        RegularCustomer rc = new RegularCustomer(2134, "Tom Cruise", "Credit Card");
        Console.WriteLine("Custmer ID: {0}\nCustomer Name: {1}\nPayment Method: {2}",rc.CustId, rc.CustName, rc.Payment);
    }
}