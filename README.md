# ������������ ������� 32.11.1 � 32.11.2 (HW-03)


## ������� 32.11.1

�������� ����������� ���� �������� � ������ ���������� � ���� ������. 
����������� ������ ����������� ����� ```LoggingMiddleware```. 
�� ������ � ����� ���������� ���� ��������� �����������.

������ ������ ���������:
```
namespace MvcStartApp.Models.Db
{
   [Table("Requests")]
   public class Request
   {
       public Guid Id { get; set; }
       public  DateTime Date { get; set; }
       public  string  Url { get; set; }
   }
}
```

## ������� 32.11.2

�������� ��������� �������������, �� ������� ����� ����� ���������� ������� �������� � ������� (�� ���� ��, ��� �� ��������� ���� � ������� 32.11.1).

������������� ������ ���� �������� �� ������ ```https://localhost:5001/logs```.