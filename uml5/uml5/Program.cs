using System;
using System.Collections.Generic;


public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Contact { get; set; }
    public string Address { get; set; }
    public int PaymentId { get; set; }

    public void Update()
    {
        Console.WriteLine("Müşteri detayları güncellendi.");
    }
}


public class Car
{
    public int Id { get; set; }
    public string Details { get; set; }
    public string OrderType { get; set; }

    public void ProcessDebit()
    {
        Console.WriteLine("Araba için borç işlendi ");
    }
}


public class RentingOwner
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string ContactNum { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }

    public void VerifyAccount()
    {
        Console.WriteLine("Hesap onaylandı.");
    }
}


public class Payment
{
    public int Id { get; set; }
    public int CardNumber { get; set; }
    public int Amount { get; set; }

    public void Add()
    {
        Console.WriteLine("Ödeme eklendi.");
    }

    public void Update()
    {
        Console.WriteLine("Ödeme güncellendi.");
    }
}


public class Rentals
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Price { get; set; }

    public void Add()
    {
        Console.WriteLine("kiralık eklendi.");
    }
}


public class Reservation
{
    public int Id { get; set; }
    public string Details { get; set; }
    public string List { get; set; }

    public void Confirmation()
    {
        Console.WriteLine("Rezervasyon onaylandı.");
    }
}


public class Transaction
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Date { get; set; }
    public string Address { get; set; }

    public void Update()
    {
        Console.WriteLine("İşlem güncellendi.");
    }
}


public class Program
{
    public static void Main()
    {
        
        Customer customer = new Customer { Id = 1, Name = "Zeynep Ece", Contact = "1234567890", Address = "316.sokak" };
        customer.Update();

        Car car = new Car { Id = 1, Details = "Sedan", OrderType = "Rent" };
        car.ProcessDebit();

        RentingOwner owner = new RentingOwner { Id = 1, Name = "Ege", Age = 45, ContactNum = "9876543210", Username = "owner1", Password = "pass123" };
        owner.VerifyAccount();

        Payment payment = new Payment { Id = 1, CardNumber = 12345678, Amount = 1000 };
        payment.Add();
        payment.Update();

        Rentals rental = new Rentals { Id = 1, Name = "Tatil evi", Price = "$500" };
        rental.Add();

        Reservation reservation = new Reservation { Id = 1, Details = "2 gün kiralık", List = "Müsait arabalar" };
        reservation.Confirmation();

        Transaction transaction = new Transaction { Id = 1, Name = "Araba Kirala", Date = "2024-12-24", Address = "123. sokak" };
        transaction.Update();
    }
}
