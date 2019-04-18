[PSCustomObject] @{
    property1 = 'Value1'
    property2 = 'Value2'
}

class MyObject
{
    $property
    [int] $intProperty = 3
    [string] $stringProperty= ''
}

$items = 1..3 | % { $str = 'x' * $_ ; [MyObject] @{ stringProperty = $str } }

$items | select { $_.stringProperty.Length }
