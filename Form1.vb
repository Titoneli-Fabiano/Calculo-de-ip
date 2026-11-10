Public Class form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ip1 As Integer
        Dim ip2 As Integer
        Dim ip3 As Integer
        Dim ip4 As Integer
        Dim red1 As Integer
        Dim red2 As Integer
        Dim red3 As Integer
        Dim red4 As Integer
        Dim brod1 As Integer
        Dim brod2 As Integer
        Dim brod3 As Integer
        Dim brod4 As Integer
        Dim m1 As Integer
        Dim m2 As Integer
        Dim m3 As Integer
        Dim m4 As Integer
        Dim B1 As Integer
        Dim B2 As Integer
        Dim B3 As Integer
        Dim B4 As Integer
        Dim B5 As Integer
        Dim B6 As Integer
        Dim B7 As Integer
        Dim B8 As Integer
        Dim B9 As Integer
        Dim B10 As Integer
        Dim B11 As Integer
        Dim B12 As Integer
        Dim B13 As Integer
        Dim B14 As Integer
        Dim B15 As Integer
        Dim B16 As Integer
        Dim B17 As Integer
        Dim B18 As Integer
        Dim B19 As Integer
        Dim B20 As Integer
        Dim B21 As Integer
        Dim B22 As Integer
        Dim B23 As Integer
        Dim B24 As Integer
        Dim B25 As Integer
        Dim B26 As Integer
        Dim B27 As Integer
        Dim B28 As Integer
        Dim B29 As Integer
        Dim B30 As Integer
        Dim B31 As Integer
        Dim B32 As Integer

        Dim ma1 As Integer
        Dim ma2 As Integer
        Dim ma3 As Integer
        Dim ma4 As Integer
        Dim ma5 As Integer
        Dim ma6 As Integer
        Dim ma7 As Integer
        Dim ma8 As Integer
        Dim ma9 As Integer
        Dim ma10 As Integer
        Dim ma11 As Integer
        Dim ma12 As Integer
        Dim ma13 As Integer
        Dim ma14 As Integer
        Dim ma15 As Integer
        Dim ma16 As Integer
        Dim ma17 As Integer
        Dim ma18 As Integer
        Dim ma19 As Integer
        Dim ma20 As Integer
        Dim ma21 As Integer
        Dim ma22 As Integer
        Dim ma23 As Integer
        Dim ma24 As Integer
        Dim ma25 As Integer
        Dim ma26 As Integer
        Dim ma27 As Integer
        Dim ma28 As Integer
        Dim ma29 As Integer
        Dim ma30 As Integer
        Dim ma31 As Integer
        Dim ma32 As Integer

        Dim br1 As Integer
        Dim br2 As Integer
        Dim br3 As Integer
        Dim br4 As Integer
        Dim br5 As Integer
        Dim br6 As Integer
        Dim br7 As Integer
        Dim br8 As Integer
        Dim br9 As Integer
        Dim br10 As Integer
        Dim br11 As Integer
        Dim br12 As Integer
        Dim br13 As Integer
        Dim br14 As Integer
        Dim br15 As Integer
        Dim br16 As Integer
        Dim br17 As Integer
        Dim br18 As Integer
        Dim br19 As Integer
        Dim br20 As Integer
        Dim br21 As Integer
        Dim br22 As Integer
        Dim br23 As Integer
        Dim br24 As Integer
        Dim br25 As Integer
        Dim br26 As Integer
        Dim br27 As Integer
        Dim br28 As Integer
        Dim br29 As Integer
        Dim br30 As Integer
        Dim br31 As Integer
        Dim br32 As Integer

        Dim mi1 As Integer
        Dim mi2 As Integer
        Dim mi3 As Integer
        Dim mi4 As Integer
        Dim mi5 As Integer
        Dim mi6 As Integer
        Dim mi7 As Integer
        Dim mi8 As Integer
        Dim mi9 As Integer
        Dim mi10 As Integer
        Dim mi11 As Integer
        Dim mi12 As Integer
        Dim mi13 As Integer
        Dim mi14 As Integer
        Dim mi15 As Integer
        Dim mi16 As Integer
        Dim mi17 As Integer
        Dim mi18 As Integer
        Dim mi19 As Integer
        Dim mi20 As Integer
        Dim mi21 As Integer
        Dim mi22 As Integer
        Dim mi23 As Integer
        Dim mi24 As Integer
        Dim mi25 As Integer
        Dim mi26 As Integer
        Dim mi27 As Integer
        Dim mi28 As Integer
        Dim mi29 As Integer
        Dim mi30 As Integer
        Dim mi31 As Integer
        Dim mi32 As Integer
        Dim bro1 As Integer
        Dim bro2 As Integer
        Dim bro3 As Integer
        Dim bro4 As Integer
        Dim bro5 As Integer
        Dim bro6 As Integer
        Dim bro7 As Integer
        Dim bro8 As Integer
        Dim bro9 As Integer
        Dim bro10 As Integer
        Dim bro11 As Integer
        Dim bro12 As Integer
        Dim bro13 As Integer
        Dim bro14 As Integer
        Dim bro15 As Integer
        Dim bro16 As Integer
        Dim bro17 As Integer
        Dim bro18 As Integer
        Dim bro19 As Integer
        Dim bro20 As Integer
        Dim bro21 As Integer
        Dim bro22 As Integer
        Dim bro23 As Integer
        Dim bro24 As Integer
        Dim bro25 As Integer
        Dim bro26 As Integer
        Dim bro27 As Integer
        Dim bro28 As Integer
        Dim bro29 As Integer
        Dim bro30 As Integer
        Dim bro31 As Integer
        Dim bro32 As Integer






        ip1 = Val(TextBox1.Text)



        If (ip1 >= 0 And ip1 <= 126) Then
            Label6.Text = "classe A"
            m1 = 255
            m2 = 0
            m3 = 0
            m4 = 0
            TextBox8.Text = m1 & (".") & m2 & (".") & m3 & (".") & m4

        End If

        If (ip1 >= 128 And ip1 < 192) Then
            Label6.Text = "classe B"
            m1 = 255
            m2 = 255
            m3 = 0
            m4 = 0
            TextBox8.Text = m1 & (".") & m2 & (".") & m3 & (".") & m4
        End If

        If (ip1 >= 192 And ip1 < 224) Then
            Label6.Text = "classe C"
            m1 = 255
            m2 = 255
            m3 = 255
            m4 = 0
            TextBox8.Text = m1 & (".") & m2 & (".") & m3 & (".") & m4
        End If

        If (ip1 >= 224 And ip1 < 240) Then
            Label6.Text = "classe D"
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()
            TextBox7.Clear()
            TextBox8.Clear()

            Label6.Text = " "

        End If

        If (ip1 >= 240 And ip1 < 256) Then
            Label6.Text = "classe E"
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()
            TextBox7.Clear()
            TextBox8.Clear()

            Label6.Text = " "


        End If

        If (ip1 < 0 Or ip1 > 255) Then
            MsgBox("por favor digite seu numero corretamente", 0, "atenção")
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()
            TextBox7.Clear()
            TextBox8.Clear()

            Label6.Text = " "

        End If


        If (ip1 >= 128) Then
            ip1 = ip1 - 128
            B1 = 1


        Else

            B1 = 0



        End If

        If (ip1 >= 64) Then
            ip1 = ip1 - 64
            B2 = 1

        Else
            B2 = 0


        End If

        If (ip1 >= 32) Then
            ip1 = ip1 - 32
            B3 = 1


        Else

            B3 = 0



        End If

        If (ip1 >= 16) Then
            ip1 = ip1 - 16
            B4 = 1

        Else
            B4 = 0


        End If

        If (ip1 >= 8) Then
            ip1 = ip1 - 8
            B5 = 1

        Else
            B5 = 0


        End If


        If (ip1 >= 4) Then
            ip1 = ip1 - 4
            B6 = 1


        Else

            B6 = 0



        End If

        If (ip1 >= 2) Then
            ip1 = ip1 - 2
            B7 = 1

        Else
            B7 = 0


        End If

        If (ip1 >= 1) Then
            ip1 = ip1 - 1
            B8 = 1

        Else
            B8 = 0


        End If





        ip2 = Val(TextBox2.Text)

        If (ip2 < 0 Or ip2 > 255) Then
            MsgBox("por favor digite seu numero corretamente", 0, "atenção")
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()
            TextBox7.Clear()
            TextBox8.Clear()

            Label6.Text = " "

        End If

        If (ip2 >= 128) Then
            ip2 = ip2 - 128
            B9 = 1


        Else

            B9 = 0



        End If

        If (ip2 >= 64) Then
            ip2 = ip2 - 64
            B10 = 1

        Else
            B10 = 0


        End If

        If (ip2 >= 32) Then
            ip2 = ip2 - 32
            B11 = 1


        Else

            B11 = 0



        End If

        If (ip2 >= 16) Then
            ip2 = ip2 - 16
            B12 = 1

        Else
            B12 = 0


        End If

        If (ip2 >= 8) Then
            ip2 = ip2 - 8
            B13 = 1

        Else
            B13 = 0


        End If


        If (ip2 >= 4) Then
            ip2 = ip2 - 4
            B14 = 1


        Else

            B14 = 0



        End If

        If (ip2 >= 2) Then
            ip2 = ip2 - 2
            B15 = 1

        Else
            B15 = 0


        End If

        If (ip2 >= 1) Then
            ip2 = ip2 - 1
            B16 = 1

        Else
            B16 = 0


        End If


        ip3 = Val(TextBox3.Text)

        If (ip3 < 0 Or ip3 > 255) Then
            MsgBox("por favor digite seu numero corretamente", 0, "atenção")
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()
            TextBox7.Clear()
            TextBox8.Clear()


            Label6.Text = " "

        End If

        If (ip3 >= 128) Then
            ip3 = ip3 - 128
            B17 = 1


        Else

            B17 = 0



        End If

        If (ip3 >= 64) Then
            ip3 = ip3 - 64
            B18 = 1

        Else
            B18 = 0


        End If

        If (ip3 >= 32) Then
            ip3 = ip3 - 32
            B19 = 1


        Else

            B19 = 0



        End If

        If (ip3 >= 16) Then
            ip3 = ip3 - 16
            B20 = 1

        Else
            B20 = 0


        End If

        If (ip3 >= 8) Then
            ip3 = ip3 - 8
            B21 = 1

        Else
            B21 = 0


        End If


        If (ip3 >= 4) Then
            ip3 = ip3 - 4
            B22 = 1


        Else

            B22 = 0



        End If

        If (ip3 >= 2) Then
            ip3 = ip3 - 2
            B23 = 1

        Else
            B23 = 0


        End If

        If (ip3 >= 1) Then
            ip3 = ip3 - 1
            B24 = 1

        Else
            B24 = 0


        End If

        ip4 = Val(TextBox4.Text)

        If (ip4 < 0 Or ip4 > 255) Then
            MsgBox("por favor digite seu numero corretamente", 0, "atenção")
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()
            TextBox7.Clear()
            TextBox8.Clear()


            Label6.Text = " "

        End If

        If (ip4 >= 128) Then
            ip4 = ip4 - 128
            B25 = 1


        Else

            B25 = 0



        End If

        If (ip4 >= 64) Then
            ip4 = ip4 - 64
            B26 = 1

        Else
            B26 = 0


        End If

        If (ip4 >= 32) Then
            ip4 = ip4 - 32
            B27 = 1


        Else

            B27 = 0



        End If

        If (ip4 >= 16) Then
            ip4 = ip4 - 16
            B28 = 1

        Else
            B28 = 0


        End If

        If (ip4 >= 8) Then
            ip4 = ip4 - 8
            B29 = 1

        Else
            B29 = 0


        End If


        If (ip4 >= 4) Then
            ip4 = ip4 - 4
            B30 = 1


        Else

            B30 = 0



        End If

        If (ip4 >= 2) Then
            ip4 = ip4 - 2
            B31 = 1

        Else
            B31 = 0


        End If

        If (ip4 >= 1) Then
            ip4 = ip4 - 1
            B32 = 1

        Else
            B32 = 0


        End If

        If (m1 = 255) Then
            ma1 = 1
            ma2 = 1
            ma3 = 1
            ma4 = 1
            ma5 = 1
            ma6 = 1
            ma7 = 1
            ma8 = 1

            mi1 = 0
            mi2 = 0
            mi3 = 0
            mi4 = 0
            mi5 = 0
            mi6 = 0
            mi7 = 0
            mi8 = 0

        Else
            ma1 = 0
            ma2 = 0
            ma3 = 0
            ma4 = 0
            ma5 = 0
            ma6 = 0
            ma7 = 0
            ma8 = 0

            mi1 = 1
            mi2 = 1
            mi3 = 1
            mi4 = 1
            mi5 = 1
            mi6 = 1
            mi7 = 1
            mi8 = 1

        End If

        If (m2 = 255) Then
            ma9 = 1
            ma10 = 1
            ma11 = 1
            ma12 = 1
            ma13 = 1
            ma14 = 1
            ma15 = 1
            ma16 = 1

            mi9 = 0
            mi10 = 0
            mi11 = 0
            mi12 = 0
            mi13 = 0
            mi14 = 0
            mi15 = 0
            mi16 = 0


        Else
            ma9 = 0
            ma10 = 0
            ma11 = 0
            ma12 = 0
            ma13 = 0
            ma14 = 0
            ma15 = 0
            ma16 = 0

            mi9 = 1
            mi10 = 1
            mi11 = 1
            mi12 = 1
            mi13 = 1
            mi14 = 1
            mi15 = 1
            mi16 = 1



        End If

        If (m3 = 255) Then

            ma17 = 1
            ma18 = 1
            ma19 = 1
            ma20 = 1
            ma21 = 1
            ma22 = 1
            ma23 = 1
            ma24 = 1

            mi17 = 0
            mi18 = 0
            mi19 = 0
            mi20 = 0
            mi21 = 0
            mi22 = 0
            mi23 = 0
            mi24 = 0


        Else

            ma17 = 0
            ma18 = 0
            ma19 = 0
            ma20 = 0
            ma21 = 0
            ma22 = 0
            ma23 = 0
            ma24 = 0

            mi17 = 1
            mi18 = 1
            mi19 = 1
            mi20 = 1
            mi21 = 1
            mi22 = 1
            mi23 = 1
            mi24 = 1





        End If

        If (m4 = 255) Then

            ma25 = 1
            ma26 = 1
            ma27 = 1
            ma28 = 1
            ma29 = 1
            ma30 = 1
            ma31 = 1
            ma32 = 1

            mi25 = 0
            mi26 = 0
            mi27 = 0
            mi28 = 0
            mi29 = 0
            mi30 = 0
            mi31 = 0
            mi32 = 0

        Else

            ma25 = 0
            ma26 = 0
            ma27 = 0
            ma28 = 0
            ma29 = 0
            ma30 = 0
            ma31 = 0
            ma32 = 0

            mi25 = 1
            mi26 = 1
            mi27 = 1
            mi28 = 1
            mi29 = 1
            mi30 = 1
            mi31 = 1
            mi32 = 1

        End If

        TextBox5.Text = ma1 & ma2 & ma3 & ma4 & ma5 & ma6 & ma7 & ma8 & (".") & ma9 & ma10 & ma11 & ma12 & ma13 & ma14 & ma15 & ma16 & (".") & ma17 & ma18 & ma19 & ma20 & ma21 & ma22 & ma23 & ma24 & (".") & ma25 & ma26 & ma27 & ma28 & ma29 & ma30 & ma31 & ma32

        br1 = B1 * ma1
        br2 = B2 * ma2
        br3 = B3 * ma3
        br4 = B4 * ma4
        br5 = B5 * ma5
        br6 = B6 * ma6
        br7 = B7 * ma7
        br8 = B8 * ma8
        br9 = B9 * ma9
        br10 = B10 * ma10
        br11 = B11 * ma11
        br12 = B12 * ma12
        br13 = B13 * ma13
        br14 = B14 * ma14
        br15 = B15 * ma15
        br16 = B16 * ma16
        br17 = B17 * ma17
        br18 = B18 * ma18
        br19 = B19 * ma19
        br20 = B20 * ma20
        br21 = B21 * ma21
        br22 = B22 * ma22
        br23 = B23 * ma23
        br24 = B24 * ma24
        br25 = B25 * ma25
        br26 = B26 * ma26
        br27 = B27 * ma27
        br28 = B28 * ma28
        br29 = B29 * ma29
        br30 = B30 * ma30
        br31 = B31 * ma31
        br32 = B32 * ma32


        red1 = br1 * 2 ^ 7 + br2 * 2 ^ 6 + br3 * 2 ^ 5 + br4 * 2 ^ 4 + br5 * 2 ^ 3 + br6 * 2 ^ 2 + br7 * 2 ^ 1 + br8 * 2 ^ 0

        red2 = br9 * 2 ^ 7 + br10 * 2 ^ 6 + br11 * 2 ^ 5 + br12 * 2 ^ 4 + br13 * 2 ^ 3 + br14 * 2 ^ 2 + br15 * 2 ^ 1 + br16 * 2 ^ 0

        red3 = br17 * 2 ^ 7 + br18 * 2 ^ 6 + br19 * 2 ^ 5 + br20 * 2 ^ 4 + br21 * 2 ^ 3 + br22 * 2 ^ 2 + br23 * 2 ^ 1 + br24 * 2 ^ 0

        red4 = br25 * 2 ^ 7 + br26 * 2 ^ 6 + br27 * 2 ^ 5 + br28 * 2 ^ 4 + br29 * 2 ^ 3 + br30 * 2 ^ 2 + br31 * 2 ^ 1 + br32 * 2 ^ 0



        TextBox7.Text = red1 & (".") & red2 & (".") & red3 & (".") & red4

        TextBox6.Text = br1 & br2 & br3 & br4 & br5 & br6 & br7 & br8 & (".") & br9 & br10 & br11 & br12 & br13 & br14 & br15 & br16 & (".") & br17 & br18 & br19 & br20 & br21 & br22 & br23 & br24 & (".") & br25 & br26 & br27 & br28 & br29 & br30 & br31 & br32


        If (br1 > 0 Or mi1 > 0) Then
            bro1 = 1

        Else
            bro1 = 0

        End If


        If (br2 > 0 Or mi2 > 0) Then
            bro2 = 1

        Else
            bro2 = 0

        End If

        If (br3 > 0 Or mi3 > 0) Then
            bro3 = 1

        Else
            bro3 = 0

        End If


        If (br4 > 0 Or mi4 > 0) Then
            bro4 = 1

        Else
            bro4 = 0

        End If

        If (br5 > 0 Or mi5 > 0) Then
            bro5 = 1

        Else
            bro5 = 0

        End If

        If (br6 > 0 Or mi6 > 0) Then
            bro6 = 1

        Else
            bro6 = 0

        End If

        If (br7 > 0 Or mi7 > 0) Then
            bro7 = 1

        Else
            bro7 = 0

        End If

        If (br8 > 0 Or mi8 > 0) Then
            bro8 = 1

        Else
            bro8 = 0

        End If

        If (br9 > 0 Or mi9 > 0) Then
            bro9 = 1

        Else
            bro9 = 0

        End If

        If (br10 > 0 Or mi10 > 0) Then
            bro10 = 1

        Else
            bro10 = 0

        End If

        If (br11 > 0 Or mi11 > 0) Then
            bro11 = 1

        Else
            bro11 = 0

        End If


        If (br12 > 0 Or mi12 > 0) Then
            bro12 = 1

        Else
            bro12 = 0

        End If

        If (br13 > 0 Or mi13 > 0) Then
            bro13 = 1

        Else
            bro13 = 0

        End If


        If (br14 > 0 Or mi14 > 0) Then
            bro14 = 1

        Else
            bro14 = 0

        End If

        If (br15 > 0 Or mi15 > 0) Then
            bro15 = 1

        Else
            bro15 = 0

        End If

        If (br16 > 0 Or mi16 > 0) Then
            bro16 = 1

        Else
            bro16 = 0

        End If

        If (br17 > 0 Or mi17 > 0) Then
            bro17 = 1

        Else
            bro17 = 0

        End If

        If (br18 > 0 Or mi18 > 0) Then
            bro18 = 1

        Else
            bro18 = 0

        End If

        If (br19 > 0 Or mi19 > 0) Then
            bro19 = 1

        Else
            bro19 = 0

        End If

        If (br20 > 0 Or mi20 > 0) Then
            bro20 = 1

        Else
            bro20 = 0

        End If

        If (br21 > 0 Or mi21 > 0) Then
            bro21 = 1

        Else
            bro21 = 0

        End If


        If (br22 > 0 Or mi22 > 0) Then
            bro22 = 1

        Else
            bro22 = 0

        End If

        If (br23 > 0 Or mi23 > 0) Then
            bro23 = 1

        Else
            bro23 = 0

        End If


        If (br24 > 0 Or mi24 > 0) Then
            bro24 = 1

        Else
            bro24 = 0

        End If

        If (br25 > 0 Or mi25 > 0) Then
            bro25 = 1

        Else
            bro25 = 0

        End If

        If (br26 > 0 Or mi26 > 0) Then
            bro26 = 1

        Else
            bro26 = 0

        End If

        If (br27 > 0 Or mi27 > 0) Then
            bro27 = 1

        Else
            bro27 = 0

        End If

        If (br28 > 0 Or mi28 > 0) Then
            bro28 = 1

        Else
            bro28 = 0

        End If

        If (br29 > 0 Or mi29 > 0) Then
            bro29 = 1

        Else
            bro29 = 0

        End If

        If (br30 > 0 Or mi30 > 0) Then
            bro30 = 1

        Else
            bro30 = 0

        End If

        If (br31 > 0 Or mi31 > 0) Then
            bro31 = 1
        Else
            bro31 = 0

        End If

        If (br32 > 0 Or mi32 > 0) Then

            bro32 = 1
        Else

            bro32 = 0
        End If

        TextBox9.Text = bro1 & bro2 & bro3 & bro4 & bro5 & bro6 & bro7 & bro8 & (".") & bro9 & bro10 & bro11 & bro12 & bro13 & bro14 & bro15 & bro16 & (".") & bro17 & bro18 & bro19 & bro20 & bro21 & bro22 & bro23 & bro24 & (".") & bro25 & bro26 & bro27 & bro28 & bro29 & bro30 & bro31 & bro32



        brod1 = bro1 * 2 ^ 7 + bro2 * 2 ^ 6 + bro3 * 2 ^ 5 + bro4 * 2 ^ 4 + bro5 * 2 ^ 3 + bro6 * 2 ^ 2 + bro7 * 2 ^ 1 + bro8 * 2 ^ 0

        brod2 = bro9 * 2 ^ 7 + bro10 * 2 ^ 6 + bro11 * 2 ^ 5 + bro12 * 2 ^ 4 + bro13 * 2 ^ 3 + bro14 * 2 ^ 2 + bro15 * 2 ^ 1 + bro16 * 2 ^ 0

        brod3 = bro17 * 2 ^ 7 + bro18 * 2 ^ 6 + bro19 * 2 ^ 5 + bro20 * 2 ^ 4 + bro21 * 2 ^ 3 + bro22 * 2 ^ 2 + bro23 * 2 ^ 1 + bro24 * 2 ^ 0

        brod4 = bro25 * 2 ^ 7 + bro26 * 2 ^ 6 + bro27 * 2 ^ 5 + bro28 * 2 ^ 4 + bro29 * 2 ^ 3 + bro30 * 2 ^ 2 + bro31 * 2 ^ 1 + bro32 * 2 ^ 0

        TextBox10.Text = brod1 & (".") & brod2 & (".") & brod3 & (".") & brod4

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        Label6.Text = " "



    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged

    End Sub
End Class
