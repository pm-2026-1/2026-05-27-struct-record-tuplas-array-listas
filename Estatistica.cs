static class Estatistica // "Módulo"
{
    public static decimal[] Amplitude(List<decimal> lista)
    {
        decimal min = decimal.MaxValue;
        decimal max = decimal.MinValue;
        foreach (var item in lista)
        {
            if (item < min) min = item;
            if (item > max) max = item;
        }
        decimal amplitude = max - min;
        
        return [min, max, amplitude];
    }

    // function/method signature (assinatura do método)
    public static 
     (decimal Minimo, decimal Maximo, decimal Amplitude) 
              AmplitudeV2(List<decimal> lista)
    {
        decimal min = decimal.MaxValue;
        decimal max = decimal.MinValue;
        foreach (var item in lista)
        {
            if (item < min) min = item;
            if (item > max) max = item;
        }
        decimal amplitude = max - min;
        
        return (min, max, amplitude);
    }


    public static Dispersão 
                       AmplitudeV3(List<decimal> lista)
    {
        decimal min = decimal.MaxValue;
        decimal max = decimal.MinValue;
        foreach (var item in lista)
        {
            if (item < min) min = item;
            if (item > max) max = item;
        }
        decimal amplitude = max - min;
        
        return new()
        {
            Mínimo = min,
            Amplitude = amplitude,
            Máximo = max,
        };
    }
}