﻿#include "pch.h"
#include <cstring>
#include <stdlib.h>
#include <iostream>
using namespace std;



const int MAXBIT = 100
, MAXVALUE = 10000
, MAXLEAF = 30
, MAXNODE = MAXLEAF * 2 - 1;

  struct HNodeType {
	  double weight;
	  int parent;
	  int lchild;
	  int rchild;
	  char value;
  }HuffNode[MAXNODE];

  struct HCodeType
  {
	  int *bit;
	  int start;
	  HCodeType(){}
	  HCodeType(int _bit[MAXBIT], int _start)
	  {
		  bit = _bit;
		  start = _start;
	  }
  }HuffCode[MAXLEAF];

void Huffman_Tree(HNodeType HuffNode[], int n)
 {
	 int i, j, x1, x2;
	 double m1, m2;
	 for (i = 0; i < 2 * n - 1; i++)
	 {
		 HuffNode[i].weight = 0;
		 HuffNode[i].parent = -1;
		 HuffNode[i].lchild = -1;
		 HuffNode[i].rchild = -1;
	 }
	 cout << "请输入value和位权";
	 HuffNode[0].weight = 5;
	 HuffNode[1].weight = 32;
	 HuffNode[2].weight = 18;
	 HuffNode[3].weight = 7;
	 HuffNode[4].weight = 25;
	 HuffNode[5].weight = 13;
	 HuffNode[0].value = 'a';
	 HuffNode[1].value = 'b';
	 HuffNode[2].value = 'c';
	 HuffNode[3].value = 'd';
	 HuffNode[4].value = 'e';
	 HuffNode[5].value = 'f';
	 for (i = 0; i < n - 1; i++)
	 {
		 m1 = m2 = MAXVALUE;
		 x1 = x2 = 0;
		 for (j = 0; j < n + i; j++)
		 {
			 if (HuffNode[j].weight < m1 && HuffNode[j].parent == -1)
			 {
				 m2 = m1;
				 x2 = x1;
				 m1 = HuffNode[j].weight;
				 x1 = j;
			 }
			 else if (HuffNode[j].weight < m2 && HuffNode[j].parent == -1)
			 {
				 m2 = HuffNode[j].weight;
				 x2 = j;
			 }
		 }
		 HuffNode[x1].parent = n + i;
		 HuffNode[x2].parent = n + i;
		 HuffNode[n + i].weight = m1 + m2;
		 HuffNode[n + i].lchild = x1;
		 HuffNode[n + i].rchild = x2;
		 cout << "x1.weight:" << HuffNode[x1].weight << "x2.weight:" << HuffNode[x2].weight << endl;
	 }
 }

void HuffmanCode(HCodeType HuffCode[], int n)
{
	HCodeType cd = HCodeType(new int[MAXBIT], 0);
	int i, j, c, p;
	for (i = 0; i < n; i++)
	{
		cd.start = n - 1;
		c = i;
		p = HuffNode[c].parent;
		while (p != -1)
		{
			if (HuffNode[p].lchild == c)
				cd.bit[cd.start] = 0;
			else
				cd.bit[cd.start] = 1;
			cd.start--;
			c = p;
			p = HuffNode[c].parent;
		}
		for (j = cd.start + 1; j < n; j++)
			HuffCode[i].bit[j] = cd.bit[j];
		HuffCode[i].start = cd.start;
	}
}

void HuffmanTree_init()
{
	for (int k = 0; k < 30; k++)
	{
		HuffCode[k] = HCodeType(new int[MAXBIT], 0);
	}
	int i, j, n;
	cout << "请输入n:";
	cin >> n;
	Huffman_Tree(HuffNode, n);
	HuffmanCode(HuffCode, n);
	for (i = 0; i < n; i++) {
		cout << "Huffman code is:" << HuffNode[i].value << endl;
		for (j = HuffCode[i].start + 1; j < n; j++)
			cout << HuffCode[i].bit[j] << endl;
	}
}
	