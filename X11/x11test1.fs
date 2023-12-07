#! /usr/bin/ueforth
\ Copyright 2021 Bradley D. Nelson
\
\ Licensed under the Apache License, Version 2.0 (the "License");
\ you may not use this file except in compliance with the License.
\ You may obtain a copy of the License at
\
\     http://www.apache.org/licenses/LICENSE-2.0
\
\ Unless required by applicable law or agreed to in writing, software
\ distributed under the License is distributed on an "AS IS" BASIS,
\ WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
\ See the License for the specific language governing permissions and
\ limitations under the License.

also x11

0 value display
0 value screen
0 value black
0 value white
0 value root-window
0 value window
0 value gc

: new-window { width height -- }
    0 XOpenDisplay to display
    display XDefaultScreen to screen
    display screen XBlackPixel to black
    display screen XWhitePixel to white
    display screen XRootWindow to root-window
    display root-window 0 0 width height 0 black white XCreateSimpleWindow to window
    display window XMapWindow drop
    display window 0 NULL XCreateGC to gc
  ;


\ set background color
: set-bg { color -- }
    display gc color XSetBackground drop
  ;
    
\ set foreground color
: set-fg { color -- }
    display gc color XSetForeground drop
  ;
    
: rect { x y width height -- }
    display window gc x y width height XDrawRectangle drop
  ;

: box { x y width height -- }
    display window gc x y width height XFillRectangle drop
  ;

: draw
\    display gc black XSetForeground drop
    display gc white XSetBackground drop
    COLOR_BLUE set-fg
    10 10  40 30 box
    COLOR_RED set-fg
    50 50 200 40 rect

    display window XMapWindow drop
\     display 1 Xsync drop
;
: gg 
    640 480 new-window
    100 ms
\     init-masks
    begin 
        draw  
        display Xflush
   again 
  ;
\ gg
