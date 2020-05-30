# Design

## General Game Flow
![](./images/program-design-logic.PNG)  

## Chess Piece
### Piece.cs  
Abstract class to define/implement <b>core</b> states and behaviors among all chess pieces  
- [x] Piece color  
- [ ] Piece move type  
- [x] Current position  

#### King.cs and Rook.cs
Piece with specific states and behaviros unique to the chess peice
- [ ] Has moved
- [ ] Queen/King side castle

## Game Properties
### GameProperties.cs
- [x] Chess game colors
- [x] Chess board square notations
- [x] Chess board file numbers
