using System;
namespace dex.net
{
	public enum Instructions
	{
		Nop,
		Move ,
		MoveFrom16 ,
		Move16 ,
		MoveWide ,
		MoveWideFrom16 ,
		MoveWide16 ,
		MoveObject ,
		MoveObjectFrom16 ,
		MoveObject16 ,
		MoveResult ,
		MoveResultWide ,
		MoveResultObject ,
		MoveException ,
		ReturnVoid ,
		ReturnValue ,
		ReturnWide ,
		ReturnObject ,
		Const4 ,
		Const16 ,
		Const ,
		ConstHigh ,
		ConstWide16 ,
		ConstWide32 ,
		ConstWide ,
		ConstWideHigh ,
		ConstString ,
		ConstStringJumbo ,
		ConstClass ,
		MonitorEnter ,
		MonitorExit ,
		CheckCast ,
		InstanceOf ,
		ArrayLength ,
		NewInstance ,
		NewArrayOf ,
		FilledNewArrayOf ,
		FilledNewArrayRange ,
		FillArrayData ,
		Throw ,
		Goto ,
		Goto16 ,
		Goto32 ,
		PackedSwitch ,
		SparseSwitch ,
		CmplFloat ,
		CmpgFloat ,
		CmplDouble ,
		CmpgDouble ,
		CmpLong ,
		IfEq ,
		IfNe ,
		IfLt ,
		IfGe ,
		IfGt ,
		IfLe ,
		IfEqz ,
		IfNez ,
		IfLtz ,
		IfGez ,
		IfGtz ,
		IfLez ,
		Aget ,
		AgetWide ,
		AgetObject ,
		AgetBoolean ,
		AgetByte ,
		AgetChar ,
		AgetShort ,
		Aput ,
		AputWide ,
		AputObject ,
		AputBoolean ,
		AputByte ,
		AputChar ,
		AputShort ,
		Iget ,
		IgetWide ,
		IgetObject ,
		IgetBoolean ,
		IgetByte ,
		IgetChar ,
		IgetShort ,
		Iput ,
		IputWide ,
		IputObject ,
		IputBoolean ,
		IputByte ,
		IputChar ,
		IputShort ,
		Sget ,
		SgetWide ,
		SgetObject ,
		SgetBoolean ,
		SgetByte ,
		SgetChar ,
		SgetShort ,
		Sput ,
		SputWide ,
		SputObject ,
		SputBoolean ,
		SputByte ,
		SputChar ,
		SputShort ,
		InvokeVirtual ,
		InvokeSuper ,
		InvokeDirect ,
		InvokeStatic ,
		InvokeInterface ,
		InvokeVirtualRange ,
		InvokeSuperRange ,
		InvokeDirectRange ,
		InvokeStaticRange ,
		InvokeInterfaceRange ,
		NegInt ,
		NotInt ,
		NegLong ,
		NotLong ,
		NegFloat ,
		NegDouble ,
		IntToLong ,
		IntToFloat ,
		IntToDouble ,
		LongToInt ,
		LongToFloat ,
		LongToDouble ,
		FloatToInt ,
		FloatToLong ,
		FloatToDouble ,
		DoubleToInt ,
		DoubleToLong ,
		DoubleToFloat ,
		IntToByte ,
		IntToChar ,
		IntToShort ,
		AddInt ,
		SubInt ,
		MulInt ,
		DivInt ,
		RemInt ,
		AndInt ,
		OrInt ,
		XorInt ,
		ShlInt ,
		ShrInt ,
		UshrInt ,
		AddLong ,
		SubLong ,
		MulLong ,
		DivLong ,
		RemLong ,
		AndLong ,
		OrLong ,
		XorLong ,
		ShlLong ,
		ShrLong ,
		UshrLong ,
		AddFloat ,
		SubFloat ,
		MulFloat ,
		DivFloat ,
		RemFloat ,
		AddDouble ,
		SubDouble ,
		MulDouble ,
		DivDouble ,
		RemDouble ,
		AddInt2Addr ,
		SubInt2Addr ,
		MulInt2Addr ,
		DivInt2Addr ,
		RemInt2Addr ,
		AndInt2Addr ,
		OrInt2Addr ,
		XorInt2Addr ,
		ShlInt2Addr ,
		ShrInt2Addr ,
		UshrInt2Addr ,
		AddLong2Addr ,
		SubLong2Addr ,
		MulLong2Addr ,
		DivLong2Addr ,
		RemLong2Addr ,
		AndLong2Addr ,
		OrLong2Addr ,
		XorLong2Addr ,
		ShlLong2Addr ,
		ShrLong2Addr ,
		UshrLong2Addr ,
		AddFloat2Addr ,
		SubFloat2Addr ,
		MulFloat2Addr ,
		DivFloat2Addr ,
		RemFloat2Addr ,
		AddDouble2Addr ,
		SubDouble2Addr ,
		MulDouble2Addr ,
		DivDouble2Addr ,
		RemDouble2Addr ,
		AddIntLit16 ,
		RsubInt ,
		MulIntLit16 ,
		DivIntLit16 ,
		RemIntLit16 ,
		AndIntLit16 ,
		OrIntLit16 ,
		XorIntLit16 ,
		AddIntLit8 ,
		RsubIntLit8 ,
		MulIntLit8 ,
		DivIntLit8 ,
		RemIntLit8 ,
		AndIntLit8 ,
		OrIntLit8 ,
		XorIntLit8 ,
		ShlIntLit8 ,
		ShrIntLit8 ,
		UshrIntLit8 ,
		Unknown
	}
}
