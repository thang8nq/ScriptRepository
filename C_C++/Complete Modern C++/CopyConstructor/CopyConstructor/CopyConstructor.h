#pragma once
class CopyConstructor
{
public:
	CopyConstructor();
	CopyConstructor(CopyConstructor &cc);

	~CopyConstructor();
};

