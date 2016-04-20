function stat=qlearn(stat)
% ------------------------------------------------------------------------
% Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
% The code is released under the FreeBSD License.
% Copyright (C) 2016 Pooyan Jamshidi, Imperial College London
% The scripts implement Fuzzy Q-learning algorithm
% ------------------------------------------------------------------------


global LAMBDA

% Q-Learning

% Finding the Max factor in the current state

q_next=max(stat.Q(stat.current_state,:));

% incrementing the learning iteration
stat.iter=stat.iter+1;

%% Setting the step-size to determine how fast learning takes place: learning rate

% 1/k
%learn_rate=1/(stat.iter);

% log(k)/k
%learn_rate=log(stat.iter+1)/(stat.iter+1);

% a/(b+k)
%learn_rate=0.5*300/(300+stat.iter);

% constant learning rate
learn_rate=0.1;

%% Value iteration update rule
% Q_old
q=stat.Q(stat.old_state,stat.old_action);

% Q_new
q=q*(1-learn_rate)+(learn_rate*(stat.rimm+(LAMBDA*q_next)));

stat.Q(stat.old_state,stat.old_action)=q;
