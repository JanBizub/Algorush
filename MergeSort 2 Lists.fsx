// You have two sorted lists. Create a new list that is sorted and contains values from the two lists.

// Algo pattern: two pointers.

// Lets call it Dynamic Array. C# List is an array under the hood anyway and the term "DynamicArray" is more generally known than ResizeArray.
type DynamicArray<'t> = ResizeArray<'t>

let list1 = ResizeArray [ 1; 2; 4; 5 ]
let list2 = ResizeArray [ 3 ]

let mergeTwoLists (l1 : DynamicArray<int>) (l2: DynamicArray<int>) =
    let mergedArray = ResizeArray<int>()
    
    let mutable i1 = 0
    let mutable i2 = 0

    while i1 < l1.Count && i2 < l2.Count do
        if l1[i1] <= l2[i2] 
        then mergedArray.Add(l1[i1]); i1 <- i1 + 1
        else mergedArray.Add(l2[i2]); i2 <- i2 + 1

    // add the rest.
    while i1 < l1.Count do
        mergedArray.Add(l1[i1])
        i1 <- i1 + 1 
    while i2 < l2.Count do
        mergedArray.Add(l2[i2])
        i2 <- i2 + 2

    mergedArray


mergeTwoLists list1 list2 
|> List.ofSeq