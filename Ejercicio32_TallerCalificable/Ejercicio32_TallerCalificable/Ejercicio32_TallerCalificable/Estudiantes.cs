using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Estudiante
{
    public int Creditos { get; set; }
    public int Estrato { get; set; }
    private const decimal ValorCreditoNormal = 100000; //Valor por credito

    //Calcular matricula por numero de creditos
    public decimal CalcularMatricula()
    {
        decimal costoTotal;

        if (Creditos <= 20)
        {
            costoTotal = Creditos * ValorCreditoNormal;
        }
        else
        {
            int creditosExtras = Creditos - 20;
            costoTotal = (20 * ValorCreditoNormal) + (creditosExtras * ValorCreditoNormal * 2);
        }

        // Aplicar descuentos por estrato
        switch (Estrato)
        {
            case 1:
                costoTotal *= 0.20m; // Descuento del 80%
                break;
            case 2:
                costoTotal *= 0.50m; // Descuento del 50%
                break;
            case 3:
                costoTotal *= 0.70m; // Descuento del 30%
                break;
        }

        return costoTotal;
    }

    public decimal CalcularSubsidio()
    {
        return Estrato switch
        {
            1 => 200000, // Subsidio para estrato 1
            2 => 100000, // Subsidio para estrato 2
            _ => 0, // Sin subsidio
        };
    }
}

