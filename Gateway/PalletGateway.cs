using Microsoft.EntityFrameworkCore;
using PalletizingReworked.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

internal class PalletsGateway
{
    private ApplicationDbContext _dbContext = new ApplicationDbContext();

    public bool Add(PalletRecord pallet)
    {
        this._dbContext.Pallets.Add(pallet);
        return (this._dbContext.SaveChanges() > 0);
    }

    public BindingList<PalletRecord> GetAll()
    {
        string date = DateTime.Now.Date.ToString();
        _dbContext.Pallets.Where(d => d.Date == date).OrderByDescending(b => b.Timestamp).Load();
        return _dbContext.Pallets.Local.ToBindingList();
    }

    public List<PalletRecord> GetNotUploadedPallet()
    {
        return _dbContext.Pallets.Where(b => b.key == null).ToList();
    }

    public PalletRecord GetPallet(string pallNumber)
    {
        return _dbContext.Pallets.FirstOrDefault(b => b.Pallet_Number == pallNumber);
    }

    public bool UpdatePallet(string pallet)
    {
        PalletRecord record = _dbContext.Pallets.FirstOrDefault(b => b.Id == pallet);
        if (record == null)
            return false;

        record.key = pallet;
        _dbContext.Update(record);
        return _dbContext.SaveChanges() > 0;
    }
}




