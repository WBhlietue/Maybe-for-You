for($i = 0; $i < 3; $i++)
{
    print("SHUTIS\n");
}
print("\n\n");

@employee = ("Alex", "Alice", "Albert");
for $name (@employee)
{
    print($name, " is an eployee\n");
}
print("\n\n");

for(@employee)
{
    print($_, " is an employee\n");
}
print("\n\n");

$cars = 7;
while($cars > 0)
{
    print("car left ", $cars--, "\n");
}
print("\n\n");

$cars = 7;
until($cars <= 0)
{
    print("car left ", $cars--, "\n");
}
print("\n\n");

$value = 0;
do
{
    print("Enter value: ");
    $value = <stdin>;
}until($value > 0);
print($value = $value ** 2);
print("\n\n");

@nums = (1..10);
for(@nums)
{
    if($_ % 2 == 0){
        print($_, " ");5
    }
}





