\ *********************************************************************
\ unit tests for UTF8
\    Filename:      tests.fs
\    Date:          02 dec 2023
\    Updated:       02 dec 2023
\    File Version:  1.1
\    MCU:           Linux / Web / Windows
\    Forth:         eForth Linux
\    Copyright:     Marc PETREMANN
\    Author:        Marc PETREMANN
\    GNU General Public License
\ *********************************************************************


$1234 100div  nip  $34  = assert
$1234 100div  drop $12  = assert

$00000000 reverse-bytes $00000000 = assert
$0000001a reverse-bytes $1a000000 = assert
$00001a2b reverse-Bytes $2b1a0000 = assert
$001a2b3c reverse-Bytes $3c2b1a00 = assert
$1a2b3c4d reverse-Bytes $4d3c2b1a = assert
$ffffffff reverse-bytes $ffffffff = assert




