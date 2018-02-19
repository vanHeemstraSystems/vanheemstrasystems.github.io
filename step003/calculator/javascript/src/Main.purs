module Main where

import Prelude
import Data.Array (drop)
import Control.Monad.Eff (Eff)
import Control.Monad.Eff.Console (CONSOLE, log)
import Node.Process (PROCESS, argv)

message :: forall t1. t1 -> t1
message s = s

main :: forall e. Eff (console :: CONSOLE, process :: PROCESS | e) Unit
main = do
    args <- argv
    log $ show (message (drop 2 args))
