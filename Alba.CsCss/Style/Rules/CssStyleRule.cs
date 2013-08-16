﻿using System.Collections.Generic;
using System.Diagnostics;

namespace Alba.CsCss.Style
{
    [DebuggerDisplay (@"{mSelector} \{ {mDeclaration.DebugDisplayCount,nq} \}")]
    public class CssStyleRule : CssRule
    {
        private readonly CssSelectorGroup mSelector;
        private readonly CssDeclaration mDeclaration;
        private int mLineNumber;

        internal CssStyleRule (CssSelectorGroup aSelector, CssDeclaration aDeclaration)
        {
            mSelector = aSelector;
            mDeclaration = aDeclaration;
        }

        internal void SetLineNumber (int aLineNumber)
        {
            mLineNumber = aLineNumber;
        }

        internal override CssRuleKind GetKind ()
        {
            return CssRuleKind.STYLE;
        }

        // Public interface

        public IEnumerable<CssSelectorGroup> SelectorGroups
        {
            get { return mSelector.Items; }
        }

        public CssDeclaration Declaration
        {
            get { return mDeclaration; }
        }

        public int LineNumber
        {
            get { return mLineNumber; }
        }
    }
}