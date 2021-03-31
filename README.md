# CSharp.17.ExtensionMethods

extiende methods de una clase afuera de la clase, solo debe cumplir dos cosas
la clase debe ser estatica
un input parameter debe ser el objeto de esta manera: this Calculadora calculadora

```csharp
public static class CalculadoraExtension
{
    public static int Mult (this Calculadora calculadora)
    {
        return calculadora.LeftValue * calculadora.RightValue;
    }       
}
```

el metodo aparecera en intellisense y ya puede ejecutarse como metodo propio de la clase
```csharp
Calculadora calc = new Calculadora(10, 12);
Console.WriteLine($"suma: {calc.Sum()}");

Console.WriteLine($"mult: {calc.Mult()}");
```

