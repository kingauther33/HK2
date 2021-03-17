<?php
    // $money = ...
    // $bank_balance = ....
    $money = 1000;
    $bank_balance = 10000;
    $savings = 2000;
    if ($bank_balance < 100)
    {
        $money = 1000;
        $bank_balance += $money;
    }
    elseif ($bank_balance > 2000)
    {
        $savings += 1000;
        $bank_balance -= 1000;
    }
    else
    {
        $savings += 500;
        $bank_balance -= 500;
    }

    echo "money = " . $money . "<br>";
    echo "bank_balance = " . ($bank_balance + 1000) . "<br>";
    echo "savings = $savings <br>";
