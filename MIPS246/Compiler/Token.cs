﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MIPS246.Core.Compiler
{
    public enum ReservedWordType
    {
        //Comment if not realize
        //AUTO,
        BREAK,
        //CASE,     soon
        CHAR,
        CONST,
        CONTINUE,
        //DEFAULT,  soon
        DO,
        DOUBLE,
        ELSE,
        //ENUM,  soon
        //EXTERN,
        //FLOAT,
        FOR,
        //GOTO,
        IF,
        INT,
        LONG,
        REGISTER,
        RETURN,
        //SHORT,
        SIGNED,
        //SIZEOF,
        STATIC,
        //STRUCT,
        //SWITCH,
        //TYPEDEF,
        //UNION,
        //UNSIGNED,
        VOID,
        //VOLATILE,
        WHILE
    }

    public enum OperatorType
    {
        
        //[
        //]
        //->
        //.
        //!
        //++
        //--
        //*
        //&
        //~
        //+
        //-
        //sizeof
        //>>
        //<<
        //<
        //<=
        //>
        //>=
        //==
        //!=
        //&
        //^
        //|
        //&&
        //||
        //?:
        //=
        //+=
        //-=
        //*=
        ///=
        //%=
        //&=
        //|=
        //^=
        //,        
    }

    public enum DelimiterType
    {
        leftParenthesis,    //(
        rightParenthesis,   //)
        leftBrace,          //{
        rightBrace,         //}
        semicolon,          //;
        comma,              //,
        ////
        ///*
        //*/
    }

    public abstract class Token
    {     

    }

    public class Identifier : Token
    {
        #region Fields
        string name;
        #endregion

        #region Constructors
        public Identifier(string name)
        {
            this.name = name;
        }
        #endregion

        #region Properties
        string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        #endregion
    }

    public class ReservedWord : Token
    {
        #region Fields
        ReservedWordType wordType;
        #endregion

        #region Properties
        public static List<string> ReservedWordList;

        public ReservedWordType WordType
        {
            set
            {
                this.wordType = value;
            }
            get
            {
                return this.wordType;
            }
        }
        #endregion

        #region Constructors
        static ReservedWord()
        {
            ReservedWordList = new List<string>();
            ReservedWordList.Add("break");
            ReservedWordList.Add("char");
            ReservedWordList.Add("const");
            ReservedWordList.Add("continue");
            ReservedWordList.Add("do");
            ReservedWordList.Add("else");
            ReservedWordList.Add("for");
            ReservedWordList.Add("if");
            ReservedWordList.Add("int");
            ReservedWordList.Add("long");
            ReservedWordList.Add("register");
            ReservedWordList.Add("return");
            ReservedWordList.Add("signed");
            ReservedWordList.Add("static");
            ReservedWordList.Add("void");
            ReservedWordList.Add("while");
        }

        public ReservedWord(ReservedWordType wordType)
        {
            this.wordType = wordType;
        }
        #endregion


    }

    public class Number : Token
    {
        #region Fields
        int value;
        #endregion

        #region Constructors
        public Number(int i)
        {
            this.value = i;
        }
        #endregion

        #region Properties
        int Value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = value;
            }

        }
        #endregion
    }

    public class Delimiter : Token
    {
        #region Fields
        DelimiterType form;
        #endregion

        #region Constructors
        public Delimiter(DelimiterType form)
        {
            this.form = form;
        }
        #endregion

        #region Properties
        DelimiterType Form
        {
            get
            {
                return this.form;
            }
            set
            {
                this.form = value;
            }
        }
        #endregion
    }

    public class Operator : Token
    {
        OperatorType type;
    }
}