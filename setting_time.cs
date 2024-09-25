class setting_time
{
    private DateTime startTime;
    private DateTime endTime;

    public DateTime getStartTime()
    {
        return startTime;
    }
    public void setStartTime(DateTime _startTime)
    {
        startTime = _startTime;
    }
    public DateTime getEndTime()
    {
        return endTime;
    }
    public void setEndTime(DateTime _endTime)
    {
        endTime = _endTime;
    }
    public setting_time()
    {

    }
    public DateTime Start()
    {
        startTime = DateTime.Now;
        return startTime;
    }
    public DateTime Stop()
    {
        endTime = DateTime.Now;
        return endTime;
    }
    private int[] data;
    private static Random ngau_nhien = new Random();
    public void Sort()
    {
        Console.Write("\nSap xep cac phan tu mang theo tung buoc:\n\n");
        hien_thi_phan_tu_mang();
        int nho_nhat;
        for (int i = 0; i < data.Length - 1; i++)
        {
            nho_nhat = i;

            for (int index = i + 1; index < data.Length; index++)
            {
                if (data[index] < data[nho_nhat])
                {
                    nho_nhat = index;
                }
            }
            trao_doi(i, nho_nhat);
            hien_thi_phan_tu_mang();
        }

    }
    public void hien_thi_phan_tu_mang()
    {
        foreach (var element in data)
        {
            Console.Write(element + " ");
        }
        Console.Write("\n\n");
    }
    public void trao_doi(int thu_nhat, int thu_hai)
    {
        int bien_tam = data[thu_nhat];
        data[thu_nhat] = data[thu_hai];
        data[thu_hai] = bien_tam;
    }
    public void Selection_Sort(int size)
    {
        data = new int[size];
        for (int i = 0; i < size; i++)
        {
            data[i] = ngau_nhien.Next(20, 90);
        }
    }
}