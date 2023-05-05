# Piramide

### esercizio in C# console che con il numero di mattoni disponibili permette di sapere il numero di piani costribili a patto che siano in modo piramidale, ovvero che si ##espandino di 1 in ogni lato per ogni piano, inoltre restituisce anche il numero di mattoni

# Codice

### casi speciali:

```C#

if (mattoni == 0){
  return 0;
}
if (mattoni == 1){
  piani = 1;
  return piani;
}
if (mattoni < 0){
  return 0;
}

```

### codice:

```C#
while (mattoni > 8){
  mattoni = mattoni  - 8;
  piani++;
}
  piani++;
  
  return piani;

```


#### il programma è incompleto
