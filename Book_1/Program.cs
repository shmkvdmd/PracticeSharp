using static System.Console;

Line();
WriteLine($"{"Type",-10} {"Byte(s) of memory"} {"Min",32} {"Max",32}");
Line();
WriteLine($"{"sbyte",-10} {sizeof(sbyte)} {sbyte.MinValue,48} {sbyte.MaxValue,32}");
WriteLine($"{"byte",-10} {sizeof(byte)} {byte.MinValue,48} {byte.MaxValue,32}");
WriteLine($"{"short",-10} {sizeof(short)} {short.MinValue,48} {short.MaxValue,32}");
WriteLine($"{"ushort",-10} {sizeof(ushort)} {ushort.MinValue,48} {ushort.MaxValue,32}");
WriteLine($"{"int",-10} {sizeof(int)} {int.MinValue,48} {int.MaxValue,32}");
WriteLine($"{"uint",-10} {sizeof(uint)} {uint.MinValue,48} {uint.MaxValue,32}");
WriteLine($"{"long",-10} {sizeof(long)} {long.MinValue,48} {long.MaxValue,32}");
WriteLine($"{"ulong",-10} {sizeof(ulong)} {ulong.MinValue,48} {ulong.MaxValue,32}");
WriteLine($"{"float",-10} {sizeof(float)} {float.MinValue,48} {float.MaxValue,32}");
WriteLine($"{"double",-10} {sizeof(double)} {double.MinValue,48} {double.MaxValue,32}");
WriteLine($"{"decimal",-8}   {sizeof(decimal)}   {decimal.MinValue,45}   {decimal.MaxValue,30}");
Line();

void Line()
{
    string line = "";
    for(int i = 0; i < WindowWidth; i++)
    {
        Write("-");
    }
}