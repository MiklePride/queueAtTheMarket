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

        ServeCustomer(customerReceipts);
    }

    static void ServeCustomer(Queue<int> customerReceipts)
    {
        int cashCount = 0;

        while (customerReceipts.Count > 0)
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