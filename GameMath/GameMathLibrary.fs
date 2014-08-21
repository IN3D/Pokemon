module GameMathLibrary.XPGroups

let popErratic (array : int[] byref) =
    for i in 1 .. 100 do
        if i = 1 then array.[i] <- 0
        elif i <= 50 then array.[i - 1] <- ((pown i 3) * (100 - i) / 50)
        elif i >= 51 && i < 68 then array.[i - 1] <- ((pown i 3) * (150 - i) / 100)
        elif i >= 68 && i < 98 then array.[i - 1] <- ((pown i 3)  * ((1911 - (10 * i)) / 3)) / 500
        else array.[i - 1] <- (pown i 3) * (160 - i) / 100

let popFast (array : int[] byref) =
    for i in 1 .. 100 do
        array.[i - 1] <- (4 * pown i 3) / 5

let popMediumFast (array : int[] byref) =
    for i in 2 .. 100 do
        array.[i - 1] <- pown i 3

let popMediumSlow (array : int[] byref) =
    for i in 2 .. 100 do
        array.[i - 1] <- int(System.Math.Floor(((6.0 / 5.0) * float(pown i 3)) - float((15 * pown i 2)) + float((100 * i) - 140)))

let popSlow (array : int[] byref) =
    for i in 2 .. 100 do
        array.[i - 1] <- (5 * (pown i 3)) / 4

let popFluctuate(array : int[] byref) =
    for i in 2 .. 100 do
        if i <= 15 then array.[i - 1] <- (pown i 3 * (((i + 1) / 3) + 24) / 50)
        elif i > 15 && i < 36 then array.[i - 1] <- int(System.Math.Floor((float(pown i 3) * ((float(i) + 14.0) / 50.0))))
        else array.[i - 1] <- (pown i 3 * ((i / 2) + 32) / 50)

let getErratic(l : int) =
    if l = 1 then 0
    elif l <= 50 then ((pown l 3) * (100 - l) / 50)
    elif l >= 51 && l < 68 then ((pown l 3) * (150 - l) / 100)
    elif l >= 68 && l < 98 then ((pown l 3) * ((1911 - (10 * l)) / 3)) / 500
    else (pown l 3) * (160 - l) / 100

let getFast (l : int) =
    (4 * pown l 3) / 5

let getMediumFast(l : int) =
    if l = 1 then 0
    else pown l 3

let getMediumSlow(l : int) =
    if l = 1 then 0
    else int(System.Math.Floor(((6.0 / 5.0) * float(pown l 3)) - float((15 * pown l 2)) + float((100 * l) - 140)))

let getSlow(l : int) =
    if l = 1 then 0
    else (5 * (pown l 3)) / 4

let getFluctuate(l : int) =
    if l = 1 then 0
    elif l <= 15 then (pown l 3 * (((l + 1) / 3) + 24) / 50)
    elif l > 15 && l < 36 then int(System.Math.Floor((float(pown l 3) * ((float(l) + 14.0) / 50.0))))
    else (pown l 3 * ((l / 2) + 32) / 50)