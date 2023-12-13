\ *********************************************************************
\ FORTHLOG - create specific words for compatibility 
\    Filename:      compatibility.fs
\    Date:          13 dec 2023
\    Updated:       13 dec 2023
\    File Version:  1.0
\    MCU:           ESP32-WROOM-32
\    Forth:         eForth all versions
\    Copyright:     Marc PETREMANN
\    Adapt. eForth: Marc PETREMANN
\    GNU General Public License
\ *********************************************************************

\ The FORTHLOG program was developped by Francis LEY on COMMODORE 64
\ with FORTH (HANDIC)

\ the definitions in this file are used to ensure compatibility between the original, 
\ pure 79-STANDARD code, with the eForth Linux code

forth definitions

: BLANKS ( addr count -- )
    blank
  ;

: in ( -- )
    >in
  ;


