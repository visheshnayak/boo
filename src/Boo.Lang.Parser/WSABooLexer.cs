// $ANTLR 2.7.5 (20050517): "wsaboo.g" -> "WSABooLexer.cs"$

namespace Boo.Lang.Parser
{
	// Generate header specific to lexer CSharp file
	using System;
	using Stream                          = System.IO.Stream;
	using TextReader                      = System.IO.TextReader;
	using Hashtable                       = System.Collections.Hashtable;
	using Comparer                        = System.Collections.Comparer;
	
	using TokenStreamException            = antlr.TokenStreamException;
	using TokenStreamIOException          = antlr.TokenStreamIOException;
	using TokenStreamRecognitionException = antlr.TokenStreamRecognitionException;
	using CharStreamException             = antlr.CharStreamException;
	using CharStreamIOException           = antlr.CharStreamIOException;
	using ANTLRException                  = antlr.ANTLRException;
	using CharScanner                     = antlr.CharScanner;
	using InputBuffer                     = antlr.InputBuffer;
	using ByteBuffer                      = antlr.ByteBuffer;
	using CharBuffer                      = antlr.CharBuffer;
	using Token                           = antlr.Token;
	using IToken                          = antlr.IToken;
	using CommonToken                     = antlr.CommonToken;
	using SemanticException               = antlr.SemanticException;
	using RecognitionException            = antlr.RecognitionException;
	using NoViableAltForCharException     = antlr.NoViableAltForCharException;
	using MismatchedCharException         = antlr.MismatchedCharException;
	using TokenStream                     = antlr.TokenStream;
	using LexerSharedInputState           = antlr.LexerSharedInputState;
	using BitSet                          = antlr.collections.impl.BitSet;
	
using Boo.Lang.Parser.Util;

	public 	class WSABooLexer : antlr.CharScanner	, TokenStream
	 {
		public const int EOF = 1;
		public const int NULL_TREE_LOOKAHEAD = 3;
		public const int ELIST = 4;
		public const int DLIST = 5;
		public const int ESEPARATOR = 6;
		public const int ABSTRACT = 7;
		public const int AND = 8;
		public const int AS = 9;
		public const int BREAK = 10;
		public const int CONTINUE = 11;
		public const int CALLABLE = 12;
		public const int CAST = 13;
		public const int CHAR = 14;
		public const int CLASS = 15;
		public const int CONSTRUCTOR = 16;
		public const int DEF = 17;
		public const int DESTRUCTOR = 18;
		public const int DO = 19;
		public const int ELIF = 20;
		public const int ELSE = 21;
		public const int END = 22;
		public const int ENSURE = 23;
		public const int ENUM = 24;
		public const int EVENT = 25;
		public const int EXCEPT = 26;
		public const int FAILURE = 27;
		public const int FINAL = 28;
		public const int FROM = 29;
		public const int FOR = 30;
		public const int FALSE = 31;
		public const int GET = 32;
		public const int GOTO = 33;
		public const int IMPORT = 34;
		public const int INTERFACE = 35;
		public const int INTERNAL = 36;
		public const int IS = 37;
		public const int ISA = 38;
		public const int IF = 39;
		public const int IN = 40;
		public const int NOT = 41;
		public const int NULL = 42;
		public const int OF = 43;
		public const int OR = 44;
		public const int OVERRIDE = 45;
		public const int NAMESPACE = 46;
		public const int PUBLIC = 47;
		public const int PROTECTED = 48;
		public const int PRIVATE = 49;
		public const int RAISE = 50;
		public const int REF = 51;
		public const int RETURN = 52;
		public const int SET = 53;
		public const int SELF = 54;
		public const int SUPER = 55;
		public const int STATIC = 56;
		public const int STRUCT = 57;
		public const int THEN = 58;
		public const int TRY = 59;
		public const int TRANSIENT = 60;
		public const int TRUE = 61;
		public const int TYPEOF = 62;
		public const int UNLESS = 63;
		public const int VIRTUAL = 64;
		public const int PARTIAL = 65;
		public const int WHILE = 66;
		public const int YIELD = 67;
		public const int ID = 68;
		public const int TRIPLE_QUOTED_STRING = 69;
		public const int EOS = 70;
		public const int NEWLINE = 71;
		public const int DOUBLE_QUOTED_STRING = 72;
		public const int SINGLE_QUOTED_STRING = 73;
		public const int LBRACK = 74;
		public const int RBRACK = 75;
		public const int LPAREN = 76;
		public const int RPAREN = 77;
		public const int ASSIGN = 78;
		public const int SUBTRACT = 79;
		public const int COMMA = 80;
		public const int ASSEMBLY_ATTRIBUTE_BEGIN = 81;
		public const int DOT = 82;
		public const int COLON = 83;
		public const int MULTIPLY = 84;
		public const int SPLICE_BEGIN = 85;
		public const int NULLABLE_SUFFIX = 86;
		public const int BITWISE_OR = 87;
		public const int LBRACE = 88;
		public const int RBRACE = 89;
		public const int QQ_BEGIN = 90;
		public const int QQ_END = 91;
		public const int INPLACE_BITWISE_OR = 92;
		public const int INPLACE_EXCLUSIVE_OR = 93;
		public const int INPLACE_BITWISE_AND = 94;
		public const int INPLACE_SHIFT_LEFT = 95;
		public const int INPLACE_SHIFT_RIGHT = 96;
		public const int CMP_OPERATOR = 97;
		public const int GREATER_THAN = 98;
		public const int LESS_THAN = 99;
		public const int ADD = 100;
		public const int EXCLUSIVE_OR = 101;
		public const int DIVISION = 102;
		public const int MODULUS = 103;
		public const int BITWISE_AND = 104;
		public const int SHIFT_LEFT = 105;
		public const int SHIFT_RIGHT = 106;
		public const int EXPONENTIATION = 107;
		public const int LONG = 108;
		public const int INCREMENT = 109;
		public const int DECREMENT = 110;
		public const int ONES_COMPLEMENT = 111;
		public const int INT = 112;
		public const int RE_LITERAL = 113;
		public const int DOUBLE = 114;
		public const int FLOAT = 115;
		public const int TIMESPAN = 116;
		public const int LINE_CONTINUATION = 117;
		public const int SL_COMMENT = 118;
		public const int ML_COMMENT = 119;
		public const int WS = 120;
		public const int X_RE_LITERAL = 121;
		public const int ESCAPED_EXPRESSION = 122;
		public const int DQS_ESC = 123;
		public const int SQS_ESC = 124;
		public const int SESC = 125;
		public const int RE_CHAR = 126;
		public const int X_RE_CHAR = 127;
		public const int RE_ESC = 128;
		public const int DIGIT_GROUP = 129;
		public const int REVERSE_DIGIT_GROUP = 130;
		public const int ID_PREFIX = 131;
		public const int ID_LETTER = 132;
		public const int DIGIT = 133;
		public const int HEXDIGIT = 134;
		
		
	protected int _skipWhitespaceRegion = 0;
	
	TokenStreamRecorder _erecorder;
	
	antlr.TokenStreamSelector _selector;
	
	internal void Initialize(antlr.TokenStreamSelector selector, int tabSize, antlr.TokenCreator tokenCreator)
	{
		setTabSize(tabSize);
		setTokenCreator(tokenCreator);
		
		_selector = selector;
		_erecorder = new TokenStreamRecorder(selector);
	}
	
	internal antlr.TokenStream CreateExpressionLexer()
	{
		WSABooExpressionLexer lexer = new WSABooExpressionLexer(getInputState());
		lexer.setTabSize(getTabSize());
		lexer.setTokenCreator(tokenCreator);
		return lexer;
	}

	internal static bool IsDigit(char ch)
	{
		return ch >= '0' && ch <= '9';
	}
	
	bool SkipWhitespace
	{
		get
		{
			return _skipWhitespaceRegion > 0;
		}
	}

	void Enqueue(antlr.IToken token, string text)
	{
		token.setText(text);
		_erecorder.Enqueue(makeESEPARATOR());
		_erecorder.Enqueue(token);
		_erecorder.Enqueue(makeESEPARATOR());
	}
	
	antlr.IToken makeESEPARATOR()
	{
		return makeToken(ESEPARATOR);
	}

	internal void EnterSkipWhitespaceRegion()
	{
		++_skipWhitespaceRegion;
	}	

	internal void LeaveSkipWhitespaceRegion()
	{
		--_skipWhitespaceRegion;
	}
		public WSABooLexer(Stream ins) : this(new ByteBuffer(ins))
		{
		}
		
		public WSABooLexer(TextReader r) : this(new CharBuffer(r))
		{
		}
		
		public WSABooLexer(InputBuffer ib)		 : this(new LexerSharedInputState(ib))
		{
		}
		
		public WSABooLexer(LexerSharedInputState state) : base(state)
		{
			initialize();
		}
		private void initialize()
		{
			caseSensitiveLiterals = true;
			setCaseSensitive(true);
			literals = new Hashtable(100, (float) 0.4, null, Comparer.Default);
			literals.Add("public", 47);
			literals.Add("namespace", 46);
			literals.Add("break", 10);
			literals.Add("while", 66);
			literals.Add("end", 22);
			literals.Add("then", 58);
			literals.Add("raise", 50);
			literals.Add("typeof", 62);
			literals.Add("and", 8);
			literals.Add("failure", 27);
			literals.Add("not", 41);
			literals.Add("return", 52);
			literals.Add("from", 29);
			literals.Add("null", 42);
			literals.Add("def", 17);
			literals.Add("protected", 48);
			literals.Add("ref", 51);
			literals.Add("class", 15);
			literals.Add("do", 19);
			literals.Add("except", 26);
			literals.Add("event", 25);
			literals.Add("unless", 63);
			literals.Add("super", 55);
			literals.Add("set", 53);
			literals.Add("transient", 60);
			literals.Add("constructor", 16);
			literals.Add("interface", 35);
			literals.Add("of", 43);
			literals.Add("is", 37);
			literals.Add("internal", 36);
			literals.Add("final", 28);
			literals.Add("yield", 67);
			literals.Add("or", 44);
			literals.Add("destructor", 18);
			literals.Add("if", 39);
			literals.Add("override", 45);
			literals.Add("as", 9);
			literals.Add("try", 59);
			literals.Add("goto", 33);
			literals.Add("enum", 24);
			literals.Add("isa", 38);
			literals.Add("for", 30);
			literals.Add("char", 14);
			literals.Add("private", 49);
			literals.Add("false", 31);
			literals.Add("static", 56);
			literals.Add("abstract", 7);
			literals.Add("partial", 65);
			literals.Add("callable", 12);
			literals.Add("get", 32);
			literals.Add("continue", 11);
			literals.Add("cast", 13);
			literals.Add("struct", 57);
			literals.Add("else", 21);
			literals.Add("import", 34);
			literals.Add("elif", 20);
			literals.Add("in", 40);
			literals.Add("self", 54);
			literals.Add("ensure", 23);
			literals.Add("true", 61);
			literals.Add("virtual", 64);
		}
		
		override public IToken nextToken()			//throws TokenStreamException
		{
			IToken theRetToken = null;
tryAgain:
			for (;;)
			{
				IToken _token = null;
				int _ttype = Token.INVALID_TYPE;
				resetText();
				try     // for char stream error handling
				{
					try     // for lexical error handling
					{
						switch ( cached_LA1 )
						{
						case '\\':
						{
							mLINE_CONTINUATION(true);
							theRetToken = returnToken_;
							break;
						}
						case '\n':  case '\r':
						{
							mNEWLINE(true);
							theRetToken = returnToken_;
							break;
						}
						case '0':  case '1':  case '2':  case '3':
						case '4':  case '5':  case '6':  case '7':
						case '8':  case '9':
						{
							mINT(true);
							theRetToken = returnToken_;
							break;
						}
						case '.':
						{
							mDOT(true);
							theRetToken = returnToken_;
							break;
						}
						case ':':
						{
							mCOLON(true);
							theRetToken = returnToken_;
							break;
						}
						case '&':
						{
							mBITWISE_AND(true);
							theRetToken = returnToken_;
							break;
						}
						case '^':
						{
							mEXCLUSIVE_OR(true);
							theRetToken = returnToken_;
							break;
						}
						case '(':
						{
							mLPAREN(true);
							theRetToken = returnToken_;
							break;
						}
						case ')':
						{
							mRPAREN(true);
							theRetToken = returnToken_;
							break;
						}
						case ']':
						{
							mRBRACK(true);
							theRetToken = returnToken_;
							break;
						}
						case '{':
						{
							mLBRACE(true);
							theRetToken = returnToken_;
							break;
						}
						case '}':
						{
							mRBRACE(true);
							theRetToken = returnToken_;
							break;
						}
						case '$':
						{
							mSPLICE_BEGIN(true);
							theRetToken = returnToken_;
							break;
						}
						case '%':
						{
							mMODULUS(true);
							theRetToken = returnToken_;
							break;
						}
						case '/':
						{
							mDIVISION(true);
							theRetToken = returnToken_;
							break;
						}
						case '~':
						{
							mONES_COMPLEMENT(true);
							theRetToken = returnToken_;
							break;
						}
						case '=':
						{
							mASSIGN(true);
							theRetToken = returnToken_;
							break;
						}
						case ',':
						{
							mCOMMA(true);
							theRetToken = returnToken_;
							break;
						}
						case '"':
						{
							mDOUBLE_QUOTED_STRING(true);
							theRetToken = returnToken_;
							break;
						}
						case '\'':
						{
							mSINGLE_QUOTED_STRING(true);
							theRetToken = returnToken_;
							break;
						}
						case '#':
						{
							mSL_COMMENT(true);
							theRetToken = returnToken_;
							break;
						}
						case '\t':  case '\u000c':  case ' ':
						{
							mWS(true);
							theRetToken = returnToken_;
							break;
						}
						case ';':
						{
							mEOS(true);
							theRetToken = returnToken_;
							break;
						}
						case '?':
						{
							mNULLABLE_SUFFIX(true);
							theRetToken = returnToken_;
							break;
						}
						default:
							if ((cached_LA1=='<') && (cached_LA2=='<') && (LA(3)=='='))
							{
								mINPLACE_SHIFT_LEFT(true);
								theRetToken = returnToken_;
							}
							else if ((cached_LA1=='>') && (cached_LA2=='>') && (LA(3)=='=')) {
								mINPLACE_SHIFT_RIGHT(true);
								theRetToken = returnToken_;
							}
							else if ((cached_LA1=='[') && (cached_LA2=='|')) {
								mQQ_BEGIN(true);
								theRetToken = returnToken_;
							}
							else if ((cached_LA1=='|') && (cached_LA2==']')) {
								mQQ_END(true);
								theRetToken = returnToken_;
							}
							else if ((cached_LA1=='+') && (cached_LA2=='+')) {
								mINCREMENT(true);
								theRetToken = returnToken_;
							}
							else if ((cached_LA1=='-') && (cached_LA2=='-')) {
								mDECREMENT(true);
								theRetToken = returnToken_;
							}
							else if ((cached_LA1=='*') && (cached_LA2=='*')) {
								mEXPONENTIATION(true);
								theRetToken = returnToken_;
							}
							else if ((cached_LA1=='<') && (cached_LA2=='<') && (true)) {
								mSHIFT_LEFT(true);
								theRetToken = returnToken_;
							}
							else if ((cached_LA1=='>') && (cached_LA2=='>') && (true)) {
								mSHIFT_RIGHT(true);
								theRetToken = returnToken_;
							}
							else if ((cached_LA1=='!'||cached_LA1=='<'||cached_LA1=='>') && (cached_LA2=='='||cached_LA2=='~')) {
								mCMP_OPERATOR(true);
								theRetToken = returnToken_;
							}
							else if ((cached_LA1=='@') && (cached_LA2=='/')) {
								mX_RE_LITERAL(true);
								theRetToken = returnToken_;
							}
							else if ((tokenSet_0_.member(cached_LA1)) && (true)) {
								mID(true);
								theRetToken = returnToken_;
							}
							else if ((cached_LA1=='|') && (true)) {
								mBITWISE_OR(true);
								theRetToken = returnToken_;
							}
							else if ((cached_LA1=='[') && (true)) {
								mLBRACK(true);
								theRetToken = returnToken_;
							}
							else if ((cached_LA1=='+') && (true)) {
								mADD(true);
								theRetToken = returnToken_;
							}
							else if ((cached_LA1=='-') && (true)) {
								mSUBTRACT(true);
								theRetToken = returnToken_;
							}
							else if ((cached_LA1=='*') && (true)) {
								mMULTIPLY(true);
								theRetToken = returnToken_;
							}
							else if ((cached_LA1=='<') && (true)) {
								mLESS_THAN(true);
								theRetToken = returnToken_;
							}
							else if ((cached_LA1=='>') && (true)) {
								mGREATER_THAN(true);
								theRetToken = returnToken_;
							}
						else
						{
							if (cached_LA1==EOF_CHAR) { uponEOF(); returnToken_ = makeToken(Token.EOF_TYPE); }
				else {throw new NoViableAltForCharException(cached_LA1, getFilename(), getLine(), getColumn());}
						}
						break; }
						if ( null==returnToken_ ) goto tryAgain; // found SKIP token
						_ttype = returnToken_.Type;
						returnToken_.Type = _ttype;
						return returnToken_;
					}
					catch (RecognitionException e) {
							throw new TokenStreamRecognitionException(e);
					}
				}
				catch (CharStreamException cse) {
					if ( cse is CharStreamIOException ) {
						throw new TokenStreamIOException(((CharStreamIOException)cse).io);
					}
					else {
						throw new TokenStreamException(cse.Message);
					}
				}
			}
		}
		
	public void mID(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = ID;
		
		{
			if ((cached_LA1=='@'))
			{
				mID_PREFIX(false);
			}
			else if ((tokenSet_1_.member(cached_LA1))) {
			}
			else
			{
				throw new NoViableAltForCharException(cached_LA1, getFilename(), getLine(), getColumn());
			}
			
		}
		mID_LETTER(false);
		{    // ( ... )*
			for (;;)
			{
				if ((tokenSet_1_.member(cached_LA1)))
				{
					mID_LETTER(false);
				}
				else if (((cached_LA1 >= '0' && cached_LA1 <= '9'))) {
					mDIGIT(false);
				}
				else
				{
					goto _loop566_breakloop;
				}
				
			}
_loop566_breakloop:			;
		}    // ( ... )*
		_ttype = testLiteralsTable(_ttype);
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	protected void mID_PREFIX(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = ID_PREFIX;
		
		match('@');
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	protected void mID_LETTER(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = ID_LETTER;
		
		{
			switch ( cached_LA1 )
			{
			case '_':
			{
				match('_');
				break;
			}
			case 'a':  case 'b':  case 'c':  case 'd':
			case 'e':  case 'f':  case 'g':  case 'h':
			case 'i':  case 'j':  case 'k':  case 'l':
			case 'm':  case 'n':  case 'o':  case 'p':
			case 'q':  case 'r':  case 's':  case 't':
			case 'u':  case 'v':  case 'w':  case 'x':
			case 'y':  case 'z':
			{
				matchRange('a','z');
				break;
			}
			case 'A':  case 'B':  case 'C':  case 'D':
			case 'E':  case 'F':  case 'G':  case 'H':
			case 'I':  case 'J':  case 'K':  case 'L':
			case 'M':  case 'N':  case 'O':  case 'P':
			case 'Q':  case 'R':  case 'S':  case 'T':
			case 'U':  case 'V':  case 'W':  case 'X':
			case 'Y':  case 'Z':
			{
				matchRange('A','Z');
				break;
			}
			default:
				if ((((cached_LA1 >= '\u0080' && cached_LA1 <= '\ufffe')))&&(System.Char.IsLetter(LA(1))))
				{
					matchRange('\u0080','\uFFFE');
				}
			else
			{
				throw new NoViableAltForCharException(cached_LA1, getFilename(), getLine(), getColumn());
			}
			break; }
		}
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	protected void mDIGIT(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = DIGIT;
		
		matchRange('0','9');
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mLINE_CONTINUATION(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = LINE_CONTINUATION;
		
		int _saveIndex = 0;
		_saveIndex = text.Length;
		match('\\');
		text.Length = _saveIndex;
		mNEWLINE(false);
		if (0==inputState.guessing)
		{
			_ttype = Token.SKIP;
		}
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mNEWLINE(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = NEWLINE;
		
		{ // ( ... )+
			int _cnt700=0;
			for (;;)
			{
				if ((cached_LA1=='\n'||cached_LA1=='\r') && (true) && (true))
				{
					{
						switch ( cached_LA1 )
						{
						case '\n':
						{
							match('\n');
							break;
						}
						case '\r':
						{
							{
								match('\r');
								{
									if ((cached_LA1=='\n') && (true) && (true))
									{
										match('\n');
									}
									else {
									}
									
								}
							}
							break;
						}
						default:
						{
							throw new NoViableAltForCharException(cached_LA1, getFilename(), getLine(), getColumn());
						}
						 }
					}
					if (0==inputState.guessing)
					{
						newline();
					}
				}
				else
				{
					if (_cnt700 >= 1) { goto _loop700_breakloop; } else { throw new NoViableAltForCharException(cached_LA1, getFilename(), getLine(), getColumn());; }
				}
				
				_cnt700++;
			}
_loop700_breakloop:			;
		}    // ( ... )+
		if (0==inputState.guessing)
		{
			
					if (SkipWhitespace)
					{
						_ttype = Token.SKIP;
					}
				
		}
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mINT(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = INT;
		
		if ((cached_LA1=='0') && (cached_LA2=='x'))
		{
			{
				match("0x");
				{ // ( ... )+
					int _cnt571=0;
					for (;;)
					{
						if ((tokenSet_2_.member(cached_LA1)))
						{
							mHEXDIGIT(false);
						}
						else
						{
							if (_cnt571 >= 1) { goto _loop571_breakloop; } else { throw new NoViableAltForCharException(cached_LA1, getFilename(), getLine(), getColumn());; }
						}
						
						_cnt571++;
					}
_loop571_breakloop:					;
				}    // ( ... )+
			}
			{
				if ((cached_LA1=='L'||cached_LA1=='l'))
				{
					{
						switch ( cached_LA1 )
						{
						case 'l':
						{
							match('l');
							break;
						}
						case 'L':
						{
							match('L');
							break;
						}
						default:
						{
							throw new NoViableAltForCharException(cached_LA1, getFilename(), getLine(), getColumn());
						}
						 }
					}
					if (0==inputState.guessing)
					{
						_ttype = LONG;
					}
				}
				else {
				}
				
			}
		}
		else if (((cached_LA1 >= '0' && cached_LA1 <= '9')) && (true)) {
			mDIGIT_GROUP(false);
			{
				if ((cached_LA1=='E'||cached_LA1=='e'))
				{
					{
						switch ( cached_LA1 )
						{
						case 'e':
						{
							match('e');
							break;
						}
						case 'E':
						{
							match('E');
							break;
						}
						default:
						{
							throw new NoViableAltForCharException(cached_LA1, getFilename(), getLine(), getColumn());
						}
						 }
					}
					{
						switch ( cached_LA1 )
						{
						case '+':
						{
							match('+');
							break;
						}
						case '-':
						{
							match('-');
							break;
						}
						case '0':  case '1':  case '2':  case '3':
						case '4':  case '5':  case '6':  case '7':
						case '8':  case '9':
						{
							break;
						}
						default:
						{
							throw new NoViableAltForCharException(cached_LA1, getFilename(), getLine(), getColumn());
						}
						 }
					}
					mDIGIT_GROUP(false);
				}
				else {
				}
				
			}
			{
				switch ( cached_LA1 )
				{
				case 'L':  case 'l':
				{
					{
						switch ( cached_LA1 )
						{
						case 'l':
						{
							match('l');
							break;
						}
						case 'L':
						{
							match('L');
							break;
						}
						default:
						{
							throw new NoViableAltForCharException(cached_LA1, getFilename(), getLine(), getColumn());
						}
						 }
					}
					if (0==inputState.guessing)
					{
						_ttype = LONG;
					}
					break;
				}
				case 'F':  case 'f':
				{
					{
						{
							switch ( cached_LA1 )
							{
							case 'f':
							{
								match('f');
								break;
							}
							case 'F':
							{
								match('F');
								break;
							}
							default:
							{
								throw new NoViableAltForCharException(cached_LA1, getFilename(), getLine(), getColumn());
							}
							 }
						}
						if (0==inputState.guessing)
						{
							_ttype = FLOAT;
						}
					}
					break;
				}
				default:
					{
						{
							{
								if (((cached_LA1=='.'))&&(WSABooLexer.IsDigit(LA(2))))
								{
									{
										match('.');
										mREVERSE_DIGIT_GROUP(false);
										{
											if ((cached_LA1=='E'||cached_LA1=='e'))
											{
												{
													switch ( cached_LA1 )
													{
													case 'e':
													{
														match('e');
														break;
													}
													case 'E':
													{
														match('E');
														break;
													}
													default:
													{
														throw new NoViableAltForCharException(cached_LA1, getFilename(), getLine(), getColumn());
													}
													 }
												}
												{
													switch ( cached_LA1 )
													{
													case '+':
													{
														match('+');
														break;
													}
													case '-':
													{
														match('-');
														break;
													}
													case '0':  case '1':  case '2':  case '3':
													case '4':  case '5':  case '6':  case '7':
													case '8':  case '9':
													{
														break;
													}
													default:
													{
														throw new NoViableAltForCharException(cached_LA1, getFilename(), getLine(), getColumn());
													}
													 }
												}
												mDIGIT_GROUP(false);
											}
											else {
											}
											
										}
									}
									{
										if ((cached_LA1=='F'||cached_LA1=='f'))
										{
											{
												{
													switch ( cached_LA1 )
													{
													case 'f':
													{
														match('f');
														break;
													}
													case 'F':
													{
														match('F');
														break;
													}
													default:
													{
														throw new NoViableAltForCharException(cached_LA1, getFilename(), getLine(), getColumn());
													}
													 }
												}
												if (0==inputState.guessing)
												{
													_ttype = FLOAT;
												}
											}
										}
										else {
											if (0==inputState.guessing)
											{
												_ttype = DOUBLE;
											}
										}
										
									}
								}
								else {
								}
								
							}
							{
								if ((cached_LA1=='d'||cached_LA1=='h'||cached_LA1=='m'||cached_LA1=='s'))
								{
									{
										switch ( cached_LA1 )
										{
										case 's':
										{
											match('s');
											break;
										}
										case 'h':
										{
											match('h');
											break;
										}
										case 'd':
										{
											match('d');
											break;
										}
										default:
											if ((cached_LA1=='m') && (cached_LA2=='s'))
											{
												match("ms");
											}
											else if ((cached_LA1=='m') && (true)) {
												match('m');
											}
										else
										{
											throw new NoViableAltForCharException(cached_LA1, getFilename(), getLine(), getColumn());
										}
										break; }
									}
									if (0==inputState.guessing)
									{
										_ttype = TIMESPAN;
									}
								}
								else {
								}
								
							}
						}
					}
				break; }
			}
		}
		else
		{
			throw new NoViableAltForCharException(cached_LA1, getFilename(), getLine(), getColumn());
		}
		
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	protected void mHEXDIGIT(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = HEXDIGIT;
		
		{
			switch ( cached_LA1 )
			{
			case 'a':  case 'b':  case 'c':  case 'd':
			case 'e':  case 'f':
			{
				matchRange('a','f');
				break;
			}
			case 'A':  case 'B':  case 'C':  case 'D':
			case 'E':  case 'F':
			{
				matchRange('A','F');
				break;
			}
			case '0':  case '1':  case '2':  case '3':
			case '4':  case '5':  case '6':  case '7':
			case '8':  case '9':
			{
				matchRange('0','9');
				break;
			}
			default:
			{
				throw new NoViableAltForCharException(cached_LA1, getFilename(), getLine(), getColumn());
			}
			 }
		}
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	protected void mDIGIT_GROUP(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = DIGIT_GROUP;
		
		mDIGIT(false);
		{    // ( ... )*
			for (;;)
			{
				switch ( cached_LA1 )
				{
				case '_':
				{
					{
						int _saveIndex = 0;
						_saveIndex = text.Length;
						match('_');
						text.Length = _saveIndex;
						mDIGIT(false);
						mDIGIT(false);
						mDIGIT(false);
					}
					break;
				}
				case '0':  case '1':  case '2':  case '3':
				case '4':  case '5':  case '6':  case '7':
				case '8':  case '9':
				{
					mDIGIT(false);
					break;
				}
				default:
				{
					goto _loop732_breakloop;
				}
				 }
			}
_loop732_breakloop:			;
		}    // ( ... )*
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	protected void mREVERSE_DIGIT_GROUP(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = REVERSE_DIGIT_GROUP;
		
		{ // ( ... )+
			int _cnt736=0;
			for (;;)
			{
				if (((cached_LA1 >= '0' && cached_LA1 <= '9')) && ((cached_LA2 >= '0' && cached_LA2 <= '9')) && ((LA(3) >= '0' && LA(3) <= '9')))
				{
					mDIGIT(false);
					mDIGIT(false);
					mDIGIT(false);
					{
						if (((cached_LA1=='_'))&&(WSABooLexer.IsDigit(LA(2))))
						{
							int _saveIndex = 0;
							_saveIndex = text.Length;
							match('_');
							text.Length = _saveIndex;
						}
						else {
						}
						
					}
				}
				else if (((cached_LA1 >= '0' && cached_LA1 <= '9')) && (true) && (true)) {
					mDIGIT(false);
				}
				else
				{
					if (_cnt736 >= 1) { goto _loop736_breakloop; } else { throw new NoViableAltForCharException(cached_LA1, getFilename(), getLine(), getColumn());; }
				}
				
				_cnt736++;
			}
_loop736_breakloop:			;
		}    // ( ... )+
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mDOT(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = DOT;
		
		match('.');
		{
			if (((cached_LA1 >= '0' && cached_LA1 <= '9')))
			{
				mREVERSE_DIGIT_GROUP(false);
				{
					if ((cached_LA1=='E'||cached_LA1=='e'))
					{
						{
							switch ( cached_LA1 )
							{
							case 'e':
							{
								match('e');
								break;
							}
							case 'E':
							{
								match('E');
								break;
							}
							default:
							{
								throw new NoViableAltForCharException(cached_LA1, getFilename(), getLine(), getColumn());
							}
							 }
						}
						{
							switch ( cached_LA1 )
							{
							case '+':
							{
								match('+');
								break;
							}
							case '-':
							{
								match('-');
								break;
							}
							case '0':  case '1':  case '2':  case '3':
							case '4':  case '5':  case '6':  case '7':
							case '8':  case '9':
							{
								break;
							}
							default:
							{
								throw new NoViableAltForCharException(cached_LA1, getFilename(), getLine(), getColumn());
							}
							 }
						}
						mDIGIT_GROUP(false);
					}
					else {
					}
					
				}
				{
					switch ( cached_LA1 )
					{
					case 'F':  case 'f':
					{
						{
							{
								switch ( cached_LA1 )
								{
								case 'f':
								{
									match('f');
									break;
								}
								case 'F':
								{
									match('F');
									break;
								}
								default:
								{
									throw new NoViableAltForCharException(cached_LA1, getFilename(), getLine(), getColumn());
								}
								 }
							}
							if (0==inputState.guessing)
							{
								_ttype = FLOAT;
							}
						}
						break;
					}
					case 'd':  case 'h':  case 'm':  case 's':
					{
						{
							{
								switch ( cached_LA1 )
								{
								case 's':
								{
									match('s');
									break;
								}
								case 'h':
								{
									match('h');
									break;
								}
								case 'd':
								{
									match('d');
									break;
								}
								default:
									if ((cached_LA1=='m') && (cached_LA2=='s'))
									{
										match("ms");
									}
									else if ((cached_LA1=='m') && (true)) {
										match('m');
									}
								else
								{
									throw new NoViableAltForCharException(cached_LA1, getFilename(), getLine(), getColumn());
								}
								break; }
							}
							if (0==inputState.guessing)
							{
								_ttype = TIMESPAN;
							}
						}
						break;
					}
					default:
						{
							if (0==inputState.guessing)
							{
								_ttype = DOUBLE;
							}
						}
					break; }
				}
			}
			else {
			}
			
		}
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mCOLON(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = COLON;
		
		match(':');
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mBITWISE_OR(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = BITWISE_OR;
		
		match('|');
		{
			if ((cached_LA1=='='))
			{
				match('=');
				if (0==inputState.guessing)
				{
					_ttype = INPLACE_BITWISE_OR;
				}
			}
			else {
			}
			
		}
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mBITWISE_AND(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = BITWISE_AND;
		
		match('&');
		{
			if ((cached_LA1=='='))
			{
				match('=');
				if (0==inputState.guessing)
				{
					_ttype = INPLACE_BITWISE_AND;
				}
			}
			else {
			}
			
		}
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mEXCLUSIVE_OR(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = EXCLUSIVE_OR;
		
		match('^');
		{
			if ((cached_LA1=='='))
			{
				match('=');
				if (0==inputState.guessing)
				{
					_ttype = INPLACE_EXCLUSIVE_OR;
				}
			}
			else {
			}
			
		}
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mLPAREN(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = LPAREN;
		
		match('(');
		if (0==inputState.guessing)
		{
			EnterSkipWhitespaceRegion();
		}
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mRPAREN(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = RPAREN;
		
		match(')');
		if (0==inputState.guessing)
		{
			LeaveSkipWhitespaceRegion();
		}
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	protected void mASSEMBLY_ATTRIBUTE_BEGIN(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = ASSEMBLY_ATTRIBUTE_BEGIN;
		
		match("assembly:");
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mLBRACK(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = LBRACK;
		
		match('[');
		if (0==inputState.guessing)
		{
			EnterSkipWhitespaceRegion();
		}
		{
			bool synPredMatched615 = false;
			if (((cached_LA1=='a')))
			{
				int _m615 = mark();
				synPredMatched615 = true;
				inputState.guessing++;
				try {
					{
						match("assembly:");
					}
				}
				catch (RecognitionException)
				{
					synPredMatched615 = false;
				}
				rewind(_m615);
				inputState.guessing--;
			}
			if ( synPredMatched615 )
			{
				match("assembly:");
				if (0==inputState.guessing)
				{
					_ttype = ASSEMBLY_ATTRIBUTE_BEGIN;
				}
			}
			else {
			}
			
		}
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mRBRACK(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = RBRACK;
		
		match(']');
		if (0==inputState.guessing)
		{
			LeaveSkipWhitespaceRegion();
		}
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mLBRACE(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = LBRACE;
		
		match('{');
		if (0==inputState.guessing)
		{
			EnterSkipWhitespaceRegion();
		}
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mRBRACE(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = RBRACE;
		
		match('}');
		if (0==inputState.guessing)
		{
			LeaveSkipWhitespaceRegion();
		}
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mSPLICE_BEGIN(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = SPLICE_BEGIN;
		
		match("$");
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mQQ_BEGIN(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = QQ_BEGIN;
		
		match("[|");
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mQQ_END(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = QQ_END;
		
		match("|]");
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mINCREMENT(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = INCREMENT;
		
		match("++");
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mDECREMENT(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = DECREMENT;
		
		match("--");
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mADD(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = ADD;
		
		{
			match('+');
		}
		{
			if ((cached_LA1=='='))
			{
				match('=');
				if (0==inputState.guessing)
				{
					_ttype = ASSIGN;
				}
			}
			else {
			}
			
		}
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mSUBTRACT(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = SUBTRACT;
		
		{
			match('-');
		}
		{
			if ((cached_LA1=='='))
			{
				match('=');
				if (0==inputState.guessing)
				{
					_ttype = ASSIGN;
				}
			}
			else {
			}
			
		}
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mMODULUS(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = MODULUS;
		
		match('%');
		{
			if ((cached_LA1=='='))
			{
				match('=');
				if (0==inputState.guessing)
				{
					_ttype = ASSIGN;
				}
			}
			else {
			}
			
		}
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mMULTIPLY(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = MULTIPLY;
		
		match('*');
		{
			if ((cached_LA1=='='))
			{
				match('=');
				if (0==inputState.guessing)
				{
					_ttype = ASSIGN;
				}
			}
			else {
			}
			
		}
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mEXPONENTIATION(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = EXPONENTIATION;
		
		match("**");
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mDIVISION(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = DIVISION;
		
		bool synPredMatched637 = false;
		if (((cached_LA1=='/') && (cached_LA2=='*') && ((LA(3) >= '\u0003' && LA(3) <= '\ufffe'))))
		{
			int _m637 = mark();
			synPredMatched637 = true;
			inputState.guessing++;
			try {
				{
					match("/*");
				}
			}
			catch (RecognitionException)
			{
				synPredMatched637 = false;
			}
			rewind(_m637);
			inputState.guessing--;
		}
		if ( synPredMatched637 )
		{
			mML_COMMENT(false);
			if (0==inputState.guessing)
			{
				_ttype = Token.SKIP;
			}
		}
		else {
			bool synPredMatched639 = false;
			if (((cached_LA1=='/') && (tokenSet_3_.member(cached_LA2)) && (tokenSet_4_.member(LA(3)))))
			{
				int _m639 = mark();
				synPredMatched639 = true;
				inputState.guessing++;
				try {
					{
						mRE_LITERAL(false);
					}
				}
				catch (RecognitionException)
				{
					synPredMatched639 = false;
				}
				rewind(_m639);
				inputState.guessing--;
			}
			if ( synPredMatched639 )
			{
				mRE_LITERAL(false);
				if (0==inputState.guessing)
				{
					_ttype = RE_LITERAL;
				}
			}
			else if ((cached_LA1=='/') && (true) && (true)) {
				match('/');
				{
					switch ( cached_LA1 )
					{
					case '/':
					{
						{
							match('/');
							{    // ( ... )*
								for (;;)
								{
									if ((tokenSet_5_.member(cached_LA1)))
									{
										{
											match(tokenSet_5_);
										}
									}
									else
									{
										goto _loop644_breakloop;
									}
									
								}
_loop644_breakloop:								;
							}    // ( ... )*
							if (0==inputState.guessing)
							{
								_ttype = Token.SKIP;
							}
						}
						break;
					}
					case '=':
					{
						{
							match('=');
							if (0==inputState.guessing)
							{
								_ttype = ASSIGN;
							}
						}
						break;
					}
					default:
						{
						}
					break; }
				}
			}
			else
			{
				throw new NoViableAltForCharException(cached_LA1, getFilename(), getLine(), getColumn());
			}
			}
			if (_createToken && (null == _token) && (_ttype != Token.SKIP))
			{
				_token = makeToken(_ttype);
				_token.setText(text.ToString(_begin, text.Length-_begin));
			}
			returnToken_ = _token;
		}
		
	protected void mML_COMMENT(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = ML_COMMENT;
		
		match("/*");
		{    // ( ... )*
			for (;;)
			{
				if (((cached_LA1=='*') && ((cached_LA2 >= '\u0003' && cached_LA2 <= '\ufffe')) && ((LA(3) >= '\u0003' && LA(3) <= '\ufffe')))&&( LA(2) != '/' ))
				{
					match('*');
				}
				else {
					bool synPredMatched685 = false;
					if (((cached_LA1=='/') && (cached_LA2=='*') && ((LA(3) >= '\u0003' && LA(3) <= '\ufffe'))))
					{
						int _m685 = mark();
						synPredMatched685 = true;
						inputState.guessing++;
						try {
							{
								match("/*");
							}
						}
						catch (RecognitionException)
						{
							synPredMatched685 = false;
						}
						rewind(_m685);
						inputState.guessing--;
					}
					if ( synPredMatched685 )
					{
						mML_COMMENT(false);
					}
					else if ((tokenSet_6_.member(cached_LA1)) && ((cached_LA2 >= '\u0003' && cached_LA2 <= '\ufffe')) && ((LA(3) >= '\u0003' && LA(3) <= '\ufffe'))) {
						{
							match(tokenSet_6_);
						}
					}
					else if ((cached_LA1=='\n'||cached_LA1=='\r')) {
						mNEWLINE(false);
					}
					else
					{
						goto _loop687_breakloop;
					}
					}
				}
_loop687_breakloop:				;
			}    // ( ... )*
			match("*/");
			if (0==inputState.guessing)
			{
				_ttype = Token.SKIP;
			}
			if (_createToken && (null == _token) && (_ttype != Token.SKIP))
			{
				_token = makeToken(_ttype);
				_token.setText(text.ToString(_begin, text.Length-_begin));
			}
			returnToken_ = _token;
		}
		
	protected void mRE_LITERAL(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = RE_LITERAL;
		
		match('/');
		{ // ( ... )+
			int _cnt718=0;
			for (;;)
			{
				if ((tokenSet_3_.member(cached_LA1)))
				{
					mRE_CHAR(false);
				}
				else
				{
					if (_cnt718 >= 1) { goto _loop718_breakloop; } else { throw new NoViableAltForCharException(cached_LA1, getFilename(), getLine(), getColumn());; }
				}
				
				_cnt718++;
			}
_loop718_breakloop:			;
		}    // ( ... )+
		match('/');
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mLESS_THAN(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = LESS_THAN;
		
		match('<');
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mSHIFT_LEFT(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = SHIFT_LEFT;
		
		match("<<");
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mINPLACE_SHIFT_LEFT(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = INPLACE_SHIFT_LEFT;
		
		match("<<=");
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mGREATER_THAN(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = GREATER_THAN;
		
		match('>');
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mSHIFT_RIGHT(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = SHIFT_RIGHT;
		
		match(">>");
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mINPLACE_SHIFT_RIGHT(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = INPLACE_SHIFT_RIGHT;
		
		match(">>=");
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mONES_COMPLEMENT(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = ONES_COMPLEMENT;
		
		match('~');
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mCMP_OPERATOR(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = CMP_OPERATOR;
		
		switch ( cached_LA1 )
		{
		case '<':
		{
			match("<=");
			break;
		}
		case '>':
		{
			match(">=");
			break;
		}
		default:
			if ((cached_LA1=='!') && (cached_LA2=='~'))
			{
				match("!~");
			}
			else if ((cached_LA1=='!') && (cached_LA2=='=')) {
				match("!=");
			}
		else
		{
			throw new NoViableAltForCharException(cached_LA1, getFilename(), getLine(), getColumn());
		}
		break; }
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mASSIGN(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = ASSIGN;
		
		match('=');
		{
			if ((cached_LA1=='='||cached_LA1=='~'))
			{
				{
					switch ( cached_LA1 )
					{
					case '=':
					{
						match('=');
						break;
					}
					case '~':
					{
						match('~');
						break;
					}
					default:
					{
						throw new NoViableAltForCharException(cached_LA1, getFilename(), getLine(), getColumn());
					}
					 }
				}
				if (0==inputState.guessing)
				{
					_ttype = CMP_OPERATOR;
				}
			}
			else {
			}
			
		}
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mCOMMA(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = COMMA;
		
		match(',');
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	protected void mTRIPLE_QUOTED_STRING(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = TRIPLE_QUOTED_STRING;
		
		int _saveIndex = 0;
		_saveIndex = text.Length;
		match("\"\"");
		text.Length = _saveIndex;
		{    // ( ... )*
			for (;;)
			{
				// nongreedy exit test
				if ((cached_LA1=='"') && (cached_LA2=='"') && (LA(3)=='"')) goto _loop665_breakloop;
				bool synPredMatched661 = false;
				if (((cached_LA1=='$') && (cached_LA2=='{') && ((LA(3) >= '\u0003' && LA(3) <= '\ufffe'))))
				{
					int _m661 = mark();
					synPredMatched661 = true;
					inputState.guessing++;
					try {
						{
							match("${");
						}
					}
					catch (RecognitionException)
					{
						synPredMatched661 = false;
					}
					rewind(_m661);
					inputState.guessing--;
				}
				if ( synPredMatched661 )
				{
					if (0==inputState.guessing)
					{
											
									Enqueue(makeToken(TRIPLE_QUOTED_STRING), text.ToString(_begin, text.Length-_begin));
									text.Length = _begin; text.Append("");
								
					}
					mESCAPED_EXPRESSION(false);
				}
				else {
					bool synPredMatched663 = false;
					if (((cached_LA1=='\\') && (cached_LA2=='$') && ((LA(3) >= '\u0003' && LA(3) <= '\ufffe'))))
					{
						int _m663 = mark();
						synPredMatched663 = true;
						inputState.guessing++;
						try {
							{
								match("\\$");
							}
						}
						catch (RecognitionException)
						{
							synPredMatched663 = false;
						}
						rewind(_m663);
						inputState.guessing--;
					}
					if ( synPredMatched663 )
					{
						_saveIndex = text.Length;
						match('\\');
						text.Length = _saveIndex;
						match('$');
					}
					else if ((tokenSet_5_.member(cached_LA1)) && ((cached_LA2 >= '\u0003' && cached_LA2 <= '\ufffe')) && ((LA(3) >= '\u0003' && LA(3) <= '\ufffe'))) {
						{
							match(tokenSet_5_);
						}
					}
					else if ((cached_LA1=='\n'||cached_LA1=='\r')) {
						mNEWLINE(false);
					}
					else
					{
						goto _loop665_breakloop;
					}
					}
				}
_loop665_breakloop:				;
			}    // ( ... )*
			_saveIndex = text.Length;
			match("\"\"\"");
			text.Length = _saveIndex;
			if (_createToken && (null == _token) && (_ttype != Token.SKIP))
			{
				_token = makeToken(_ttype);
				_token.setText(text.ToString(_begin, text.Length-_begin));
			}
			returnToken_ = _token;
		}
		
	protected void mESCAPED_EXPRESSION(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = ESCAPED_EXPRESSION;
		
		int _saveIndex = 0;
		_saveIndex = text.Length;
		match("${");
		text.Length = _saveIndex;
		if (0==inputState.guessing)
		{
						
					_erecorder.Enqueue(makeESEPARATOR());
					if (0 == _erecorder.RecordUntil(CreateExpressionLexer(), RBRACE, LBRACE))
					{	
						_erecorder.Dequeue();			
					}
					else
					{
						_erecorder.Enqueue(makeESEPARATOR());
					}
					refresh();
				
		}
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mDOUBLE_QUOTED_STRING(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = DOUBLE_QUOTED_STRING;
		
		int _saveIndex = 0;
		_saveIndex = text.Length;
		match('"');
		text.Length = _saveIndex;
		{
			if (((cached_LA1=='"') && (cached_LA2=='"') && ((LA(3) >= '\u0003' && LA(3) <= '\ufffe')))&&(LA(1)=='"' && LA(2)=='"'))
			{
				mTRIPLE_QUOTED_STRING(false);
				if (0==inputState.guessing)
				{
					_ttype = TRIPLE_QUOTED_STRING;
				}
			}
			else if ((tokenSet_5_.member(cached_LA1)) && (true) && (true)) {
				{
					{    // ( ... )*
						for (;;)
						{
							bool synPredMatched671 = false;
							if (((cached_LA1=='$') && (cached_LA2=='{') && (tokenSet_5_.member(LA(3)))))
							{
								int _m671 = mark();
								synPredMatched671 = true;
								inputState.guessing++;
								try {
									{
										match("${");
									}
								}
								catch (RecognitionException)
								{
									synPredMatched671 = false;
								}
								rewind(_m671);
								inputState.guessing--;
							}
							if ( synPredMatched671 )
							{
								if (0==inputState.guessing)
								{
														
														Enqueue(makeToken(DOUBLE_QUOTED_STRING), text.ToString(_begin, text.Length-_begin));
														text.Length = _begin; text.Append("");
													
								}
								mESCAPED_EXPRESSION(false);
							}
							else if ((tokenSet_7_.member(cached_LA1)) && (tokenSet_5_.member(cached_LA2)) && (true)) {
								{
									match(tokenSet_7_);
								}
							}
							else if ((cached_LA1=='\\')) {
								mDQS_ESC(false);
							}
							else
							{
								goto _loop673_breakloop;
							}
							
						}
_loop673_breakloop:						;
					}    // ( ... )*
					_saveIndex = text.Length;
					match('"');
					text.Length = _saveIndex;
				}
			}
			else
			{
				throw new NoViableAltForCharException(cached_LA1, getFilename(), getLine(), getColumn());
			}
			
		}
		if (0==inputState.guessing)
		{
			
					if (_erecorder.Count > 0)
					{
						Enqueue(makeToken(DOUBLE_QUOTED_STRING), text.ToString(_begin, text.Length-_begin));
						_ttype = ESEPARATOR;
						text.Length = _begin; text.Append("");			
						_selector.push(_erecorder);
					}
				
		}
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	protected void mDQS_ESC(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = DQS_ESC;
		
		int _saveIndex = 0;
		_saveIndex = text.Length;
		match('\\');
		text.Length = _saveIndex;
		{
			switch ( cached_LA1 )
			{
			case '0':  case '\\':  case 'a':  case 'b':
			case 'f':  case 'n':  case 'r':  case 't':
			case 'u':
			{
				mSESC(false);
				break;
			}
			case '"':
			{
				match('"');
				break;
			}
			case '$':
			{
				match('$');
				break;
			}
			default:
			{
				throw new NoViableAltForCharException(cached_LA1, getFilename(), getLine(), getColumn());
			}
			 }
		}
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mSINGLE_QUOTED_STRING(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = SINGLE_QUOTED_STRING;
		
		int _saveIndex = 0;
		_saveIndex = text.Length;
		match('\'');
		text.Length = _saveIndex;
		{    // ( ... )*
			for (;;)
			{
				if ((cached_LA1=='\\'))
				{
					mSQS_ESC(false);
				}
				else if ((tokenSet_8_.member(cached_LA1))) {
					{
						match(tokenSet_8_);
					}
				}
				else
				{
					goto _loop677_breakloop;
				}
				
			}
_loop677_breakloop:			;
		}    // ( ... )*
		_saveIndex = text.Length;
		match('\'');
		text.Length = _saveIndex;
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	protected void mSQS_ESC(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = SQS_ESC;
		
		int _saveIndex = 0;
		_saveIndex = text.Length;
		match('\\');
		text.Length = _saveIndex;
		{
			switch ( cached_LA1 )
			{
			case '0':  case '\\':  case 'a':  case 'b':
			case 'f':  case 'n':  case 'r':  case 't':
			case 'u':
			{
				mSESC(false);
				break;
			}
			case '\'':
			{
				match('\'');
				break;
			}
			default:
			{
				throw new NoViableAltForCharException(cached_LA1, getFilename(), getLine(), getColumn());
			}
			 }
		}
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mSL_COMMENT(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = SL_COMMENT;
		
		match("#");
		{    // ( ... )*
			for (;;)
			{
				if ((tokenSet_5_.member(cached_LA1)))
				{
					{
						match(tokenSet_5_);
					}
				}
				else
				{
					goto _loop681_breakloop;
				}
				
			}
_loop681_breakloop:			;
		}    // ( ... )*
		if (0==inputState.guessing)
		{
			_ttype = Token.SKIP;
		}
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mWS(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = WS;
		
		{ // ( ... )+
			int _cnt690=0;
			for (;;)
			{
				switch ( cached_LA1 )
				{
				case ' ':
				{
					match(' ');
					break;
				}
				case '\t':
				{
					match('\t');
					if (0==inputState.guessing)
					{
						tab();
					}
					break;
				}
				case '\u000c':
				{
					match('\f');
					break;
				}
				default:
				{
					if (_cnt690 >= 1) { goto _loop690_breakloop; } else { throw new NoViableAltForCharException(cached_LA1, getFilename(), getLine(), getColumn());; }
				}
				break; }
				_cnt690++;
			}
_loop690_breakloop:			;
		}    // ( ... )+
		if (0==inputState.guessing)
		{
			
					_ttype = Token.SKIP;
				
		}
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mEOS(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = EOS;
		
		match(';');
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mX_RE_LITERAL(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = X_RE_LITERAL;
		
		int _saveIndex = 0;
		_saveIndex = text.Length;
		match('@');
		text.Length = _saveIndex;
		match('/');
		{ // ( ... )+
			int _cnt694=0;
			for (;;)
			{
				if ((tokenSet_9_.member(cached_LA1)))
				{
					mX_RE_CHAR(false);
				}
				else
				{
					if (_cnt694 >= 1) { goto _loop694_breakloop; } else { throw new NoViableAltForCharException(cached_LA1, getFilename(), getLine(), getColumn());; }
				}
				
				_cnt694++;
			}
_loop694_breakloop:			;
		}    // ( ... )+
		match('/');
		if (0==inputState.guessing)
		{
			_ttype = RE_LITERAL;
		}
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	protected void mX_RE_CHAR(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = X_RE_CHAR;
		
		switch ( cached_LA1 )
		{
		case ' ':
		{
			match(' ');
			break;
		}
		case '\t':
		{
			match('\t');
			break;
		}
		default:
			if ((tokenSet_3_.member(cached_LA1)))
			{
				mRE_CHAR(false);
			}
		else
		{
			throw new NoViableAltForCharException(cached_LA1, getFilename(), getLine(), getColumn());
		}
		break; }
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	protected void mSESC(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = SESC;
		
		switch ( cached_LA1 )
		{
		case 'r':
		{
			{
				int _saveIndex = 0;
				_saveIndex = text.Length;
				match('r');
				text.Length = _saveIndex;
				if (0==inputState.guessing)
				{
					text.Length = _begin; text.Append("\r");
				}
			}
			break;
		}
		case 'n':
		{
			{
				int _saveIndex = 0;
				_saveIndex = text.Length;
				match('n');
				text.Length = _saveIndex;
				if (0==inputState.guessing)
				{
					text.Length = _begin; text.Append("\n");
				}
			}
			break;
		}
		case 't':
		{
			{
				int _saveIndex = 0;
				_saveIndex = text.Length;
				match('t');
				text.Length = _saveIndex;
				if (0==inputState.guessing)
				{
					text.Length = _begin; text.Append("\t");
				}
			}
			break;
		}
		case 'a':
		{
			{
				int _saveIndex = 0;
				_saveIndex = text.Length;
				match('a');
				text.Length = _saveIndex;
				if (0==inputState.guessing)
				{
					text.Length = _begin; text.Append("\a");
				}
			}
			break;
		}
		case 'b':
		{
			{
				int _saveIndex = 0;
				_saveIndex = text.Length;
				match('b');
				text.Length = _saveIndex;
				if (0==inputState.guessing)
				{
					text.Length = _begin; text.Append("\b");
				}
			}
			break;
		}
		case 'f':
		{
			{
				int _saveIndex = 0;
				_saveIndex = text.Length;
				match('f');
				text.Length = _saveIndex;
				if (0==inputState.guessing)
				{
					text.Length = _begin; text.Append("\f");
				}
			}
			break;
		}
		case '0':
		{
			{
				int _saveIndex = 0;
				_saveIndex = text.Length;
				match('0');
				text.Length = _saveIndex;
				if (0==inputState.guessing)
				{
					text.Length = _begin; text.Append("\0");
				}
			}
			break;
		}
		case 'u':
		{
			{
				int _saveIndex = 0;
				_saveIndex = text.Length;
				match('u');
				text.Length = _saveIndex;
				mHEXDIGIT(false);
				mHEXDIGIT(false);
				mHEXDIGIT(false);
				mHEXDIGIT(false);
				if (0==inputState.guessing)
				{
					
											char ch = (char)int.Parse(text.ToString(_begin, 4), System.Globalization.NumberStyles.HexNumber);
											text.Length = _begin;
											text.Append(ch);
										
				}
			}
			break;
		}
		case '\\':
		{
			{
				int _saveIndex = 0;
				_saveIndex = text.Length;
				match('\\');
				text.Length = _saveIndex;
				if (0==inputState.guessing)
				{
					text.Length = _begin; text.Append("\\");
				}
			}
			break;
		}
		default:
		{
			throw new NoViableAltForCharException(cached_LA1, getFilename(), getLine(), getColumn());
		}
		 }
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	protected void mRE_CHAR(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = RE_CHAR;
		
		if ((cached_LA1=='\\'))
		{
			mRE_ESC(false);
		}
		else if ((tokenSet_10_.member(cached_LA1))) {
			{
				match(tokenSet_10_);
			}
		}
		else
		{
			throw new NoViableAltForCharException(cached_LA1, getFilename(), getLine(), getColumn());
		}
		
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	protected void mRE_ESC(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = RE_ESC;
		
		match('\\');
		{
			switch ( cached_LA1 )
			{
			case '+':
			{
				match('+');
				break;
			}
			case '/':
			{
				match('/');
				break;
			}
			case '(':
			{
				match('(');
				break;
			}
			case ')':
			{
				match(')');
				break;
			}
			case '|':
			{
				match('|');
				break;
			}
			case '.':
			{
				match('.');
				break;
			}
			case '*':
			{
				match('*');
				break;
			}
			case '?':
			{
				match('?');
				break;
			}
			case '$':
			{
				match('$');
				break;
			}
			case '^':
			{
				match('^');
				break;
			}
			case '[':
			{
				match('[');
				break;
			}
			case ']':
			{
				match(']');
				break;
			}
			case '{':
			{
				match('{');
				break;
			}
			case '}':
			{
				match('}');
				break;
			}
			case 'a':
			{
				match('a');
				break;
			}
			case 'b':
			{
				match('b');
				break;
			}
			case 'c':
			{
				{
					match('c');
					matchRange('A','Z');
				}
				break;
			}
			case 't':
			{
				match('t');
				break;
			}
			case 'r':
			{
				match('r');
				break;
			}
			case 'v':
			{
				match('v');
				break;
			}
			case 'f':
			{
				match('f');
				break;
			}
			case 'n':
			{
				match('n');
				break;
			}
			case 'e':
			{
				match('e');
				break;
			}
			case '0':  case '1':  case '2':  case '3':
			case '4':  case '5':  case '6':  case '7':
			case '8':  case '9':
			{
				{ // ( ... )+
					int _cnt726=0;
					for (;;)
					{
						if (((cached_LA1 >= '0' && cached_LA1 <= '9')) && (tokenSet_5_.member(cached_LA2)) && (true))
						{
							mDIGIT(false);
						}
						else
						{
							if (_cnt726 >= 1) { goto _loop726_breakloop; } else { throw new NoViableAltForCharException(cached_LA1, getFilename(), getLine(), getColumn());; }
						}
						
						_cnt726++;
					}
_loop726_breakloop:					;
				}    // ( ... )+
				break;
			}
			case 'x':
			{
				{
					match('x');
					mHEXDIGIT(false);
					mHEXDIGIT(false);
				}
				break;
			}
			case 'u':
			{
				{
					match('u');
					mHEXDIGIT(false);
					mHEXDIGIT(false);
					mHEXDIGIT(false);
					mHEXDIGIT(false);
				}
				break;
			}
			case '\\':
			{
				match('\\');
				break;
			}
			case 'w':
			{
				match('w');
				break;
			}
			case 'W':
			{
				match('W');
				break;
			}
			case 's':
			{
				match('s');
				break;
			}
			case 'S':
			{
				match('S');
				break;
			}
			case 'd':
			{
				match('d');
				break;
			}
			case 'D':
			{
				match('D');
				break;
			}
			case 'p':
			{
				match('p');
				break;
			}
			case 'P':
			{
				match('P');
				break;
			}
			case 'A':
			{
				match('A');
				break;
			}
			case 'z':
			{
				match('z');
				break;
			}
			case 'Z':
			{
				match('Z');
				break;
			}
			case 'g':
			{
				match('g');
				break;
			}
			case 'B':
			{
				match('B');
				break;
			}
			case 'k':
			{
				match('k');
				break;
			}
			default:
			{
				throw new NoViableAltForCharException(cached_LA1, getFilename(), getLine(), getColumn());
			}
			 }
		}
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	public void mNULLABLE_SUFFIX(bool _createToken) //throws RecognitionException, CharStreamException, TokenStreamException
{
		int _ttype; IToken _token=null; int _begin=text.Length;
		_ttype = NULLABLE_SUFFIX;
		
		match('?');
		if (_createToken && (null == _token) && (_ttype != Token.SKIP))
		{
			_token = makeToken(_ttype);
			_token.setText(text.ToString(_begin, text.Length-_begin));
		}
		returnToken_ = _token;
	}
	
	
	private static long[] mk_tokenSet_0_()
	{
		long[] data = new long[3072];
		data[0]=0L;
		data[1]=576460745995190271L;
		for (int i = 2; i<=1022; i++) { data[i]=-1L; }
		data[1023]=9223372036854775807L;
		for (int i = 1024; i<=3071; i++) { data[i]=0L; }
		return data;
	}
	public static readonly BitSet tokenSet_0_ = new BitSet(mk_tokenSet_0_());
	private static long[] mk_tokenSet_1_()
	{
		long[] data = new long[3072];
		data[0]=0L;
		data[1]=576460745995190270L;
		for (int i = 2; i<=1022; i++) { data[i]=-1L; }
		data[1023]=9223372036854775807L;
		for (int i = 1024; i<=3071; i++) { data[i]=0L; }
		return data;
	}
	public static readonly BitSet tokenSet_1_ = new BitSet(mk_tokenSet_1_());
	private static long[] mk_tokenSet_2_()
	{
		long[] data = new long[1025];
		data[0]=287948901175001088L;
		data[1]=541165879422L;
		for (int i = 2; i<=1024; i++) { data[i]=0L; }
		return data;
	}
	public static readonly BitSet tokenSet_2_ = new BitSet(mk_tokenSet_2_());
	private static long[] mk_tokenSet_3_()
	{
		long[] data = new long[2048];
		data[0]=-140741783332360L;
		for (int i = 1; i<=1022; i++) { data[i]=-1L; }
		data[1023]=9223372036854775807L;
		for (int i = 1024; i<=2047; i++) { data[i]=0L; }
		return data;
	}
	public static readonly BitSet tokenSet_3_ = new BitSet(mk_tokenSet_3_());
	private static long[] mk_tokenSet_4_()
	{
		long[] data = new long[2048];
		data[0]=-4294977032L;
		for (int i = 1; i<=1022; i++) { data[i]=-1L; }
		data[1023]=9223372036854775807L;
		for (int i = 1024; i<=2047; i++) { data[i]=0L; }
		return data;
	}
	public static readonly BitSet tokenSet_4_ = new BitSet(mk_tokenSet_4_());
	private static long[] mk_tokenSet_5_()
	{
		long[] data = new long[2048];
		data[0]=-9224L;
		for (int i = 1; i<=1022; i++) { data[i]=-1L; }
		data[1023]=9223372036854775807L;
		for (int i = 1024; i<=2047; i++) { data[i]=0L; }
		return data;
	}
	public static readonly BitSet tokenSet_5_ = new BitSet(mk_tokenSet_5_());
	private static long[] mk_tokenSet_6_()
	{
		long[] data = new long[2048];
		data[0]=-4398046520328L;
		for (int i = 1; i<=1022; i++) { data[i]=-1L; }
		data[1023]=9223372036854775807L;
		for (int i = 1024; i<=2047; i++) { data[i]=0L; }
		return data;
	}
	public static readonly BitSet tokenSet_6_ = new BitSet(mk_tokenSet_6_());
	private static long[] mk_tokenSet_7_()
	{
		long[] data = new long[2048];
		data[0]=-17179878408L;
		data[1]=-268435457L;
		for (int i = 2; i<=1022; i++) { data[i]=-1L; }
		data[1023]=9223372036854775807L;
		for (int i = 1024; i<=2047; i++) { data[i]=0L; }
		return data;
	}
	public static readonly BitSet tokenSet_7_ = new BitSet(mk_tokenSet_7_());
	private static long[] mk_tokenSet_8_()
	{
		long[] data = new long[2048];
		data[0]=-549755823112L;
		data[1]=-268435457L;
		for (int i = 2; i<=1022; i++) { data[i]=-1L; }
		data[1023]=9223372036854775807L;
		for (int i = 1024; i<=2047; i++) { data[i]=0L; }
		return data;
	}
	public static readonly BitSet tokenSet_8_ = new BitSet(mk_tokenSet_8_());
	private static long[] mk_tokenSet_9_()
	{
		long[] data = new long[2048];
		data[0]=-140737488364552L;
		for (int i = 1; i<=1022; i++) { data[i]=-1L; }
		data[1023]=9223372036854775807L;
		for (int i = 1024; i<=2047; i++) { data[i]=0L; }
		return data;
	}
	public static readonly BitSet tokenSet_9_ = new BitSet(mk_tokenSet_9_());
	private static long[] mk_tokenSet_10_()
	{
		long[] data = new long[2048];
		data[0]=-140741783332360L;
		data[1]=-268435457L;
		for (int i = 2; i<=1022; i++) { data[i]=-1L; }
		data[1023]=9223372036854775807L;
		for (int i = 1024; i<=2047; i++) { data[i]=0L; }
		return data;
	}
	public static readonly BitSet tokenSet_10_ = new BitSet(mk_tokenSet_10_());
	
}
}