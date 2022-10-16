// 16. Дано число обозначающее день недели. 
// Выяснить является номер дня недели выходным 


int GetNumDayOfWeek()
{
    Console.Write("Введите число дня недели от 1 до 7: ");
    return Convert.ToInt32(Console.ReadLine());
}

string GetDay(int value){
    string[] week = {"Понедельник", "Вторник","Среда","Четверг", "Пятница", "Суббота","Воскресенье"};
    return week[value-1];
}

bool IsHoliday(int value){
    if (value==6 || value==7) return true;
    else return false;
}

void PrintResult(int value){
    if (IsHoliday(value)){
        Console.WriteLine($"День недели {value} это {GetDay(value)} и он является выходным");
    } else{
        Console.WriteLine($"День недели {value} это {GetDay(value)} и он НЕ является выходным");
    }
}

int val  = GetNumDayOfWeek();
PrintResult(val);