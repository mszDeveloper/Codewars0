#https://www.codewars.com/kata/5a6b24d4e626c59d5b000066


import math

def FindNextPower(number, pow = 2):
    root = math.pow(number + 1, 1./pow)
    ceilRoot = math.ceil(root)
    nextPower = ceilRoot ** pow
    return int(nextPower)

def IsNumberInArr(arr, n):
    if (len(arr) == 0): return False
    for item in arr:
        if (item == n): return True
    return False

def SquareSumRec(a, n, arr):
    b = 0
    c = a
    while True:
        c = FindNextPower(c)
        b = c - a
        if b == a or IsNumberInArr(arr, b): continue 
        if b > n: break 
        arrNext = list(arr)
        arrNext.append(b) 
        if len(arrNext) == n: return arrNext 
        resultArr = SquareSumRec(b, n, arrNext) 
        if resultArr != False: return resultArr 
    return False

def square_sums_row(n):
    for a in range(1, n + 1):
        arr = list()
        arr.append(a)
        resultArr = SquareSumRec(a, n, arr)
        if resultArr != False: return resultArr
    return False

print(square_sums_row(15))

#def square_sums_row(n):

#    def dfs():
#        if not inp: yield res
#        for v in tuple(inp):
#            if not res or not ((res[-1]+v)**.5 % 1):
#                res.append(v)
#                inp.discard(v)
#                yield from dfs()
#                inp.add(res.pop())

#    inp, res = set(range(1,n+1)), []
#    return next(dfs(), False)

#from math import sqrt
#def square_sums_row(n, lst=[0]):
#    if len(lst) == n+1: return lst[1:]
#    for i in range(1, n+1):
#        if i in lst: continue
#        if sqrt(lst[-1]+i).is_integer(): 
#            res = square_sums_row(n, lst+[i])
#            if res: return res
#    return False