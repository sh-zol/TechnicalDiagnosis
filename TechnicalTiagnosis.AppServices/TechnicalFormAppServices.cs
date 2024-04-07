using TechnicalTiagnosis.Core.Contracts.AppServices;
using TechnicalTiagnosis.Core.Contracts.Service;
using TechnicalTiagnosis.Core.Entities;
using TechnicalTiagnosis.Core.Enums;

namespace TechnicalTiagnosis.AppServices;

public class TechnicalFormAppServices : ITechnicalFormAppServices
{
    private readonly IThenicalFormServices _thenicalFormServices;
    private readonly IBaseServices _baseServices;

    public TechnicalFormAppServices(IThenicalFormServices thenicalFormServices,
        IBaseServices baseServices)
    {
        _thenicalFormServices = thenicalFormServices;
        _baseServices = baseServices;
    }

    public List<string> Create(TechnicalForm model)
    {
        var messages = new List<string>();

        if (!_baseServices.IsValidForSubmit(model.CreateAt))
        {
            messages.Add("طول عمر ماشین بیشتر از 5 سال است");
            return messages;
        }

        var isEven = _baseServices.IsEven(model.CreateAt);

        switch (model.Car.CarType)
        {
            case CarTypes.IranKhodro:
                {
                    if (isEven)
                    {
                        var capacity = _thenicalFormServices.Capacity(model.CreateAt);
                        if (capacity < 10)
                        {
                            // create form 
                        }
                        else
                        {
                            messages.Add($"ضرفیت روز انتخابی {model.CreateAt}  پر شده است ");
                        }
                    }
                    else
                    {
                        messages.Add("ماشین های ایران خودرو فقط در روز های زوج میتوانند نوبت بگیرند");
                    }

                    return messages;
                }


            case CarTypes.Saipa:
                if (!isEven)
                {
                    var capacity = _thenicalFormServices.Capacity(model.CreateAt);
                    if (capacity < 5)
                    {
                        // create form 
                    }
                    else
                    {
                        messages.Add($"ضرفیت روز انتخابی {model.CreateAt}  پر شده است ");
                    }
                }
                else
                {
                    messages.Add("ماشین های سایپا فقط در روز های فرد میتوانند نوبت بگیرند");
                }

                return messages;
        }
        return messages;
    }
}

