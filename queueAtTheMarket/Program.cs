class program
{
    static void Main(string[] args)
    {
        Queue<int> customerReceipts = new Queue<int>();
        customerReceipts.Enqueue(435);
        customerReceipts.Enqueue(110);
        customerReceipts.Enqueue(78);
        customerReceipts.Enqueue(397);
        customerReceipts.Enqueue(1140);
        customerReceipts.Enqueue(113);
        customerReceipts.Enqueue(600);
        customerReceipts.Enqueue(788);

        ServingCustomer(customerReceipts);
    }

    static void ServingCustomer(Queue<int> customerReceipts)
    {
        int cashCount = 0;
        int customerReceiptsCount = 0;

        foreach (int receipts in customerReceipts)
        {
            customerReceiptsCount++;
        }

        for (int i = 0; i < customerReceiptsCount; i++)
        {
            Console.WriteLine($"Сумма чека текущего покупателя - {customerReceipts.Peek()}руб.");
            cashCount += customerReceipts.Dequeue();
            Console.WriteLine($"Покупатель обработан. В кассе магазина: {cashCount}руб.\n" +
                $"Нажмите любую кнопку, чтобы принять следующего покупателя...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}