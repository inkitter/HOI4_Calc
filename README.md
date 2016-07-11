# HOI4 Damage Calc · 钢铁雄心4 伤害计算器

## 本程序需要 .NET Framework 4.5。

Github： https://github.com/inkitter/HOI4_Calc

计算简单介绍： http://wiki.inkit.org/g:hoi:damagecalc 或 http://bbs.3dmgame.com/thread-5233752-1-1.html



## 陆军伤害计算
1. 根据攻击方、防御方属性，一回合一回合模拟计算。
2. 可以调整的参数：陆军组织度骰子、陆军兵力骰子、陆军基本伤害参数、进攻方组织度衰减、命中率参数。
3. 进攻方组织度衰减会每回合降低进攻方的组织度，游戏默认值是0.2，为了一些目的，可以设置为0。
4. 部队的作战能力会根据兵力损耗降低，这个也模拟进去了。

## 目前文本框可以输入字母，会导致发生错误，以后会慢慢修正。
## 数据改完注意按Apply键来保存。

## 计算方法：在下方 ATK 和 DEF 文本框内输入相应的部队代码，再点击calc计算。