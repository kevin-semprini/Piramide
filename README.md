# Piramide

### esercizio in C# console che con il numero di mattoni disponibili permette di sapere il numero di piani costribili a patto che siano in modo piramidale, ovvero che si ##espandino di 1 in ogni lato per ogni piano, inoltre restituisce anche il numero di mattoni

# Codice per i piani

### variabili:

```C#
int molti = 0;
int temp = 1;
int piani = 0;
```

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
do {
  if (temp > mattoni){
    break;
  }
  temp = temp + 8*molti;
  molti = molti + 1;
  mattoni = mattoni - temp;
  piani++;
  if (mattoni <= 7){
    break;
  }
}while (mattoni > 8 && piani >= 1);

return piani;

```


# Codice per i mattoni rimanenti:


### variabili:

```C#
int molti = 0;
int temp = 1;
int piani = 0;
```

### casi speciali:

```C#
if (mattoni == 0){
  return 0;
}
if (mattoni == 1){
  piani = 0;
  return piani;
}
if (mattoni < 0){
  return 0;
}
```

### codice:

```C#
do {
  if (temp > mattoni){
    break;
  }
  temp = temp + 8*molti;
  molti = molti + 1;
  mattoni = mattoni - temp;
  piani++;
  if (mattoni <= 7){
    break;
   }
}while (mattoni > 8 && piani >= 1);
return mattoni;

```


