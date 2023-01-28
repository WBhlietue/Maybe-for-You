{-# LANGUAGE CPP #-}
{-# LANGUAGE NoRebindableSyntax #-}
{-# OPTIONS_GHC -fno-warn-missing-import-lists #-}
{-# OPTIONS_GHC -Wno-missing-safe-haskell-mode #-}
module Paths_helloW (
    version,
    getBinDir, getLibDir, getDynLibDir, getDataDir, getLibexecDir,
    getDataFileName, getSysconfDir
  ) where

import qualified Control.Exception as Exception
import Data.Version (Version(..))
import System.Environment (getEnv)
import Prelude

#if defined(VERSION_base)

#if MIN_VERSION_base(4,0,0)
catchIO :: IO a -> (Exception.IOException -> IO a) -> IO a
#else
catchIO :: IO a -> (Exception.Exception -> IO a) -> IO a
#endif

#else
catchIO :: IO a -> (Exception.IOException -> IO a) -> IO a
#endif
catchIO = Exception.catch

version :: Version
version = Version [0,1,0,0] []
bindir, libdir, dynlibdir, datadir, libexecdir, sysconfdir :: FilePath

bindir     = "D:\\Documents\\vscode\\haskell\\helloW\\.stack-work\\install\\74ab0724\\bin"
libdir     = "D:\\Documents\\vscode\\haskell\\helloW\\.stack-work\\install\\74ab0724\\lib\\x86_64-windows-ghc-9.0.2\\helloW-0.1.0.0-GaojCujbzpsKyQHiAj19Tb-helloW"
dynlibdir  = "D:\\Documents\\vscode\\haskell\\helloW\\.stack-work\\install\\74ab0724\\lib\\x86_64-windows-ghc-9.0.2"
datadir    = "D:\\Documents\\vscode\\haskell\\helloW\\.stack-work\\install\\74ab0724\\share\\x86_64-windows-ghc-9.0.2\\helloW-0.1.0.0"
libexecdir = "D:\\Documents\\vscode\\haskell\\helloW\\.stack-work\\install\\74ab0724\\libexec\\x86_64-windows-ghc-9.0.2\\helloW-0.1.0.0"
sysconfdir = "D:\\Documents\\vscode\\haskell\\helloW\\.stack-work\\install\\74ab0724\\etc"

getBinDir, getLibDir, getDynLibDir, getDataDir, getLibexecDir, getSysconfDir :: IO FilePath
getBinDir = catchIO (getEnv "helloW_bindir") (\_ -> return bindir)
getLibDir = catchIO (getEnv "helloW_libdir") (\_ -> return libdir)
getDynLibDir = catchIO (getEnv "helloW_dynlibdir") (\_ -> return dynlibdir)
getDataDir = catchIO (getEnv "helloW_datadir") (\_ -> return datadir)
getLibexecDir = catchIO (getEnv "helloW_libexecdir") (\_ -> return libexecdir)
getSysconfDir = catchIO (getEnv "helloW_sysconfdir") (\_ -> return sysconfdir)

getDataFileName :: FilePath -> IO FilePath
getDataFileName name = do
  dir <- getDataDir
  return (dir ++ "\\" ++ name)
