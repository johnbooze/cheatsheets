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

# Tuples are an easy way to store multi-dimensional data
$tuple1 = [System.Tuple]::Create('First Dimension','Second Dimension')
$tuple2 = [System.Tuple]::Create('First Dimension','Second Dimension')
$tuple1 -eq $tuple2
$tupleHash = @{}
$tupleHash.Add($tuple1, $tuple1)
$tupleHash.Add($tuple2, $tuple2)
# Error because the tuple uniquely defines the 'key'