## Problem

You are in charge for creating a system that stores coffee machines. Each coffee machine has a brewing unit but only some have grinders.

Please create a class diagram to store these coffee machines.  Only those two aspects about a coffee machine are important to capture at this point but the design must be extendible.

For example, in future I may ask you to extend the design to store coffee machines with a WIFI coffee reordering module and so on.  How would an instance of a coffee machine be created? 

## Solution

- Use the factory pattern to create an instance of the coffee machine.
- For the factory's `Create()` method, pass in features that you want the coffee machine to have.
- Use composition to add a list of features to the coffee machine.
- Features follow a common interface that allows different implementations of its `Operate()` method.

## UML Diagram

[![](https://mermaid.ink/img/pako:eNq9VMtuwjAQ_BXLJ6Dk0KuFIhWqIqTSHlqpF1-seANWiYMcR1VE4du7eRgS5EQcUHOJY8_O7GPiA41SCZTRaCey7FmJjREJ11xX32SRxjHAWkRbpeEFhM0NfBZ7IAeuCT5vqYZ6tTRKSzD1x5eK1TqV-Q4Pjxe2VZdORDY1haN6WBjkh1Fcq2SEkVeV2dPKl8NpjMedg47Qf-l4Y85CJG41jPX20qHf92DKxMb9pTjqgNyWvaN-krLZcmVjnDdk7ELmBn5qwOi8twTbwOZFmXmLrK-4bjGNSe7boYvZ7sXL9WymtAUTiwjC0GvbYUytUWJA50nJrlIdhv2J-H-N2W8Q-M3MiNJbMMpmZbpeSBCEV-5hJKq8n11FEE4fOSUTFON0gqueavx2r5J0k23nNQBvzeymSgZG6JQHQS29ARydUpxVIpTEC7HyEqd2CwlwynAphfnmFD2COJHb9KPQEWXW5DCl-V5iY5v7k7JY7DLcBamwgHVzw5av4x9Hte1m?type=png)](https://mermaid.live/edit#pako:eNq9VMtuwjAQ_BXLJ6Dk0KuFIhWqIqTSHlqpF1-seANWiYMcR1VE4du7eRgS5EQcUHOJY8_O7GPiA41SCZTRaCey7FmJjREJ11xX32SRxjHAWkRbpeEFhM0NfBZ7IAeuCT5vqYZ6tTRKSzD1x5eK1TqV-Q4Pjxe2VZdORDY1haN6WBjkh1Fcq2SEkVeV2dPKl8NpjMedg47Qf-l4Y85CJG41jPX20qHf92DKxMb9pTjqgNyWvaN-krLZcmVjnDdk7ELmBn5qwOi8twTbwOZFmXmLrK-4bjGNSe7boYvZ7sXL9WymtAUTiwjC0GvbYUytUWJA50nJrlIdhv2J-H-N2W8Q-M3MiNJbMMpmZbpeSBCEV-5hJKq8n11FEE4fOSUTFON0gqueavx2r5J0k23nNQBvzeymSgZG6JQHQS29ARydUpxVIpTEC7HyEqd2CwlwynAphfnmFD2COJHb9KPQEWXW5DCl-V5iY5v7k7JY7DLcBamwgHVzw5av4x9Hte1m)


## Prerequities

In order to the run this project, you must have both [Docker](https://www.docker.com/) (and Docker Compose) installed.

## Run the container

```sh
docker compose up -d
``` 

## Start interactive session with container

```sh
docker compose exec dotnet /bin/bash
```

## Run Coffee Machine project

If you're already in an interactive session with the container

```sh
dotnet run
```

If you're still on the host (local) terminal

```sh
docker compose exe coffee-machine dotnet run
```


## Stop the container

If you are still in the interactive session with the container 
```sh
exit
```

Once you're back on the host machine
```sh
docker compose down
```
