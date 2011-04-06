%% Pretty printing table (see also Jsfax.generated.pp)
[
   FSIdentifier                        -- _1,
   FSLambdaExp                         -- H[ KW["function"] _1 KW["("] _2 KW[")"] _3 ],
   FSTypedLambdaExp                    -- H[ KW["function"] _1 KW["("] _2 KW[")"] KW[":"] _3 _4 ],
   FSTypedIdentifier                   -- H[ _1 KW[":"] _2 ],
   FSTypedFunctionExp                  -- V[ V is=2[ H[ KW["function"] KW["("] _1 KW[")"] KW[":"] _2 KW["{"]] _3] KW["}"]],
   FSTypedFunctionExp.1:iter-star-sep  -- _1 KW[","],
   FSTypedFunctionExp.3:iter-star      -- _1,
   FSTypedFunctionDecl                 -- V[ V is=2[ H[ KW["function"] _1 KW["("] _2 KW[")"] KW[":"] _3 KW["{"]] _4] KW["}"]],
   FSTypedFunctionDecl.2:iter-star-sep -- _1 KW[","],
   FSTypedFunctionDecl.4:iter-star     -- _1,
   FSUndefined                         -- KW["undefined"],
   
   JSModule                       -- V vs=1[_1],
   JSModule.1:iter-star           -- _1,
   JSVarDeclNoInit                -- H[KW["var"] _1 KW[";"]],
   JSVarDeclNoInit.1:iter-star-sep-- _1 KW[","],
   JSVarDecl                      -- H hs=0[ H[KW["var"] _1 KW["="] _2] KW[";"]],
   JSFor                          -- V[ H[KW["for"] KW["("] _1 _2 KW[";"] _3 KW[")"]] _4],
   JSForIn                        -- V[ H[KW["for"] KW["("] KW["var"] _1 KW["in"] _2 KW[")"]] _3],
   JSIf                           -- V[ H[KW["if"] KW["("] _1 KW[")"]] _2 KW["else"] _3],
   JSIfNoElse                     -- V[ H[KW["if"] KW["("] _1 KW[")"]] _2],
   JSWhile                        -- V[ H[KW["while"] KW["("] _1 KW[")"]] _2],
   JSTryCatch                     -- V[V is=2[ H[ KW["try"] KW["{"]] _1] V is=2[H[KW["}"] KW["catch"] KW["("] _2 KW[")"] KW["{"]] _3] KW["}"]],
   JSTryCatch.1:iter-star         -- _1,
   JSTryCatch.3:iter-star         -- _1,
   JSSwitch                       -- V is=2[ H[KW["switch"] KW["("] _1 KW[")"] KW["{"]] _2 KW["}"]],
   JSSwitch.2:iter-star           -- _1,
   JSCase                         -- KW["case"] _1 KW[":"] _2,
   JSCase.2:iter-star             -- _1,
   JSCase                         -- V  [H  [KW["default"] KW[":"]] _1],
   JSCase.1:iter-star             -- _1,
   JSBreak                        -- H[KW["break"] KW[";"]],
   JSThrow                        -- H[KW["throw"] _1 KW[";"]],
   JSReturn                       -- H hs=0[ H[ KW["return"] _1] KW[";"]],
   JSReturn                       -- H vs=0[KW["return"] KW[";"]],
   JSDelete                       -- H[KW["delete"] _1 KW[";"]],
   JSExpStat                      -- H hs=0[_1 KW[";"]],
   JSBlock                        -- V is=2[KW["{"] _1] KW["}"],
   JSBlock.1:iter-star            -- _1,
   JSFunctionDecl                 -- V[ V is=4[ H[ KW["function"] H hs=0[_1 KW["("] _2 KW[")"]] KW["{"]] _3] KW["}"]],
   JSFunctionDecl.2:iter-star-sep -- _1 KW[", "],
   JSFunctionDecl.3:iter-star     -- _1,
   JSAsyncFunctionDecl                 -- V[ V is=2[ H[ KW["function"] _1 KW["~("] _2 KW[")"] KW["{"]] _3] KW["}"]],
   JSAsyncFunctionDecl.2:iter-star-sep -- _1 KW[","],
   JSAsyncFunctionDecl.3:iter-star     -- _1,
   JSAssign                       -- H[_1 _2 _3],
   JSLFieldAccess                 -- H hs=0[_1 KW["."] _2],
   JSLVar                         -- _1,
   JSLPropAccess                  -- H hs=0[_1 KW["["] _2 KW["]"]],
   JSStringLit                    -- _1,
   JSIntLit                       -- _1,
   JSVar                          -- _1,
   JSTrue                         -- KW["true"],
   JSFalse                        -- KW["false"],
   JSThis                         -- KW["this"],
   JSNull                         -- KW["null"],
   JSArrayCons                    -- KW["["] _1 KW["]"],
   JSArrayCons.1:iter-star-sep    -- _1 KW[","],
   JSNew                          -- KW["new"] _1 KW["("] _2 KW[")"],
   JSNew.2:iter-star-sep          -- _1 KW[","],
   JSObj                          -- KW["{"] _1 KW["}"],
   JSObj.1:iter-star-sep          -- _1 KW[","],
   JSPropVal                      -- _1 KW[":"] _2,
   JSPropVal                      -- _1 KW[":"] _2,
   JSInc                          -- _1 KW["++"],
   JSDec                          -- _1 KW["--"],
   JSNot                          -- KW["!"] _1,
   JSTypeOf                       -- KW["typeof"] _1,
   JSIn                           -- _1 KW[" in "] _2,
   JSChoice                       -- _1 KW["?"] _2 KW[":"] _3,
   JSBracket                      -- KW["("] _1 KW[")"],
   JSOp                          -- _1 KW["+"] _2,
   JSFieldAccess                  -- H hs=0[_1 KW["."] _2],
   JSCall                         -- _1 KW["("] _2 KW[")"],
   JSCall.2:iter-star-sep         -- _1 KW[","],
   JSAsyncCall                    -- _1 KW["~("] _2 KW[")"],
   JSAsyncCall.2:iter-star-sep    -- _1 KW[","],
   JSPropAccess                   -- H hs=0[_1 _2],
   JSIndex                        -- KW["["] _1 KW["]"],
   JSFunctionExp                  -- V[ V is=4[ H hs=0[ KW["function"] KW["("] _1 KW[")"] KW[" {"]] _2] KW["}"]],
   JSFunctionExp.1:iter-star-sep  -- _1 KW[", "],
   JSFunctionExp.2:iter-star      -- _1,
   JSAsyncFunctionExp                  -- V[ V is=2[ H hs=0[ KW["function"] KW["~("] _1 KW[")"] KW[" {"]] _2] KW["}"]],
   JSAsyncFunctionExp.1:iter-star-sep  -- _1 KW[", "],
   JSAsyncFunctionExp.2:iter-star      -- _1
]










